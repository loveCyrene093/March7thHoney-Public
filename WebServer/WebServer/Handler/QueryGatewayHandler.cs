using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf;
using March7thHoney.Configuration;
using March7thHoney.Data;
using March7thHoney.Proto;
using March7thHoney.Util;
using March7thHoney.WebServer.Request;

namespace March7thHoney.WebServer.Handler;

internal class QueryGatewayHandler
{
	public static Logger Logger = new Logger("GatewayServer");

	public string Data;

	private static bool GatewayDebugEnabled => ConfigManager.Config.ServerOption.LogOption.EnableGamePacketLog;

	private static void Debug(string message)
	{
		if (GatewayDebugEnabled)
		{
			Logger.Debug(message);
		}
	}

	public QueryGatewayHandler(GateWayRequest req)
	{
		ConfigContainer config = ConfigManager.Config;
		bool value = string.Equals(req.is_new_format, "1", StringComparison.Ordinal);
		Debug($"query_gateway begin: version={req.version} uid={req.uid} lang={req.language_type} platform={req.platform_type} channel={req.channel_id}/{req.sub_channel_id} is_new_format={value}");
		ClientVersionCache.Update(req.version);
		GateServer gateServer = new GateServer
		{
			RegionName = config.GameServer.GameServerId,
			Ip = config.GameServer.PublicAddress,
			Port = config.GameServer.Port,
			Msg = "Access verification failed. Please check if you have logged in to the correct account and server."
		};
		gateServer.Unk1 = true;
		gateServer.Unk2 = true;
		gateServer.Unk3 = true;
		gateServer.Unk4 = true;
		gateServer.Unk5 = true;
		gateServer.Unk6 = true;
		gateServer.Unk7 = true;
		gateServer.Unk8 = true;
		gateServer.Unk9 = true;
		gateServer.MdkResVersion = "0";
		gateServer.IfixVersion = "0";
		if (ConfigManager.Config.GameServer.UsePacketEncryption)
		{
			gateServer.ClientSecretKey = Convert.ToBase64String(Crypto.ClientSecretKey.GetBytes());
		}
		string baseUrl = (req.version.StartsWith("CN", StringComparison.OrdinalIgnoreCase) ? "https://autopatchcn.bhsr.com/" : "https://autopatchos.starrails.com/");
		bool flag = false;
		if (ConfigManager.Config.HttpServer.SendHotfix && ConfigManager.Config.HttpServer.UseFetchRemoteHotfix)
		{
			flag = FetchRemoteHotfix(req, gateServer).GetAwaiter().GetResult();
		}
		if (ConfigManager.Config.HttpServer.SendHotfix)
		{
			if (!flag)
			{
				UseLocalHotfix(req, baseUrl, gateServer);
			}
		}
		else
		{
			SetEmptyHotfix(gateServer);
		}
		if (!ResourceManager.IsLoaded)
		{
			Logger.Warn("query_gateway requested before ResourceManager finished loading; returning retcode=0 for client compatibility");
		}
		Logger.Info("Client request: query_gateway");
		byte[] array = gateServer.ToByteArray();
		Data = Convert.ToBase64String(array);
		Debug($"query_gateway result: protoBytes={array.Length}, base64Length={Data.Length}, retcode={gateServer.Retcode}");
		Debug($"query_gateway gate: region={gateServer.RegionName} ip={gateServer.Ip} port={gateServer.Port} encryption={(gateServer.ClientSecretKey?.Length ?? 0) > 0}");
		Debug($"query_gateway hotfix: ab={gateServer.AssetBundleUrl} exRes={gateServer.ExResourceUrl} lua={gateServer.LuaUrl} ifix={gateServer.IfixUrl}");
	}

	private async Task<bool> FetchRemoteHotfix(GateWayRequest req, GateServer gateServer)
	{
		try
		{
			string gatewayUrlByVersion = GetGatewayUrlByVersion(req.version);
			Dictionary<string, string> source = new Dictionary<string, string>
			{
				["version"] = req.version,
				["t"] = req.t,
				["uid"] = req.uid,
				["language_type"] = req.language_type,
				["platform_type"] = req.platform_type,
				["dispatch_seed"] = req.dispatch_seed,
				["channel_id"] = req.channel_id,
				["sub_channel_id"] = req.sub_channel_id,
				["is_need_url"] = req.is_need_url,
				["game_version"] = req.game_version,
				["account_type"] = req.account_type,
				["account_uid"] = req.account_uid
			};
			string text = string.Join("&", source.Select((KeyValuePair<string, string> kv) => kv.Key + "=" + kv.Value));
			string url = gatewayUrlByVersion + "?" + text;
			var (num, text2) = await HttpNetwork.SendGetRequest(url, 5);
			if (num == 200 && !string.IsNullOrEmpty(text2))
			{
				try
				{
					byte[] data = Convert.FromBase64String(text2);
					GateServer gateServer2 = GateServer.Parser.ParseFrom(data);
					if (!string.IsNullOrEmpty(gateServer2.AssetBundleUrl))
					{
						gateServer.AssetBundleUrl = gateServer2.AssetBundleUrl;
						gateServer.AssetBundleUrlAndroid = gateServer2.AssetBundleUrlAndroid;
						gateServer.ExResourceUrl = gateServer2.ExResourceUrl;
						gateServer.LuaUrl = gateServer2.LuaUrl;
						gateServer.IfixUrl = gateServer2.IfixUrl;
						return true;
					}
					Logger.Warn("Remote hotfix return empty, fall back to local hotfix");
				}
				catch (Exception ex)
				{
					Logger.Warn("Failed to parse remote hotfix response: " + ex.Message);
				}
			}
			else
			{
				Logger.Warn($"Remote hotfix request failed with status: {num}");
			}
		}
		catch (Exception ex2)
		{
			Logger.Warn("Remote hotfix fetch failed: " + ex2.Message);
		}
		return false;
	}

	private void UseLocalHotfix(GateWayRequest req, string baseUrl, GateServer gateServer)
	{
		ConfigManager.Hotfix.HotfixData.TryGetValue(req.version, out DownloadUrlConfig value);
		if (value != null)
		{
			gateServer.AssetBundleUrl = NormalizeHotfixUrl(baseUrl, value.AssetBundleUrl);
			gateServer.AssetBundleUrlAndroid = NormalizeHotfixUrl(baseUrl, value.ExAssetBundleUrl);
			gateServer.ExResourceUrl = NormalizeHotfixUrl(baseUrl, value.ExResourceUrl);
			gateServer.LuaUrl = NormalizeHotfixUrl(baseUrl, value.LuaUrl);
			gateServer.IfixUrl = NormalizeHotfixUrl(baseUrl, value.IfixUrl);
		}
		else
		{
			Logger.Warn("No local hotfix found for version: " + req.version);
		}
	}

	private static string NormalizeHotfixUrl(string baseUrl, string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return string.Empty;
		}
		if (value.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || value.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
		{
			return value;
		}
		if (value.StartsWith("/", StringComparison.Ordinal))
		{
			return baseUrl.TrimEnd('/') + value;
		}
		return baseUrl.TrimEnd('/') + "/" + value;
	}

	private static void SetEmptyHotfix(GateServer gateServer)
	{
		gateServer.AssetBundleUrl = string.Empty;
		gateServer.AssetBundleUrlAndroid = string.Empty;
		gateServer.ExResourceUrl = string.Empty;
		gateServer.LuaUrl = string.Empty;
		gateServer.IfixUrl = string.Empty;
	}

	private string GetGatewayUrlByVersion(string version)
	{
		if (version.Contains("CNPROD", StringComparison.OrdinalIgnoreCase))
		{
			return "https://prod-gf-cn-dp01.bhsr.com/query_gateway";
		}
		if (version.Contains("CNBETA", StringComparison.OrdinalIgnoreCase))
		{
			return "https://beta-release01-cn.bhsr.com/query_gateway";
		}
		if (version.Contains("OSPROD", StringComparison.OrdinalIgnoreCase))
		{
			return "https://prod-official-asia-dp01.starrails.com/query_gateway";
		}
		if (version.Contains("OSBETA", StringComparison.OrdinalIgnoreCase))
		{
			return "https://beta-release01-asia.starrails.com/query_gateway";
		}
		string text = version.Substring(0, 2);
		if (!text.Equals("CN", StringComparison.OrdinalIgnoreCase))
		{
			return "https://prod-official-asia-dp01.starrails.com/query_gateway";
		}
		return "https://prod-gf-cn-dp01.bhsr.com/query_gateway";
	}
}
