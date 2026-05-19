using System;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf;
using March7thHoney.Configuration;
using March7thHoney.Proto;
using March7thHoney.Util;
using March7thHoney.WebServer.Handler;
using March7thHoney.WebServer.Objects;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace March7thHoney.WebServer.Controllers;

[ApiController]
[EnableCors("AllowAll")]
[Route("/")]
public class DispatchRoutes : ControllerBase
{
	public static Logger Logger = new Logger("DispatchServer");

	private static ConfigContainer Config => ConfigManager.Config;

	private static bool DispatchDebugEnabled => Config.ServerOption.LogOption.EnableGamePacketLog;

	private static void Debug(string message)
	{
		if (DispatchDebugEnabled)
		{
			Logger.Debug(message);
		}
	}

	private static void Debug(string message, Exception e)
	{
		if (DispatchDebugEnabled)
		{
			Logger.Debug(message, e);
		}
	}

	[HttpGet("query_dispatch")]
	public IActionResult QueryDispatch()
	{
		if (!Config.ServerOption.ServerConfig.RunDispatch)
		{
			return Content(string.Empty, "text/plain");
		}
		string publicBaseUrl = GetPublicBaseUrl();
		try
		{
			HttpRequest request = base.HttpContext.Request;
			string value = base.HttpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";
			int remotePort = base.HttpContext.Connection.RemotePort;
			string value2 = request.Headers.UserAgent.ToString();
			StringValues value3 = request.Query["is_new_format"];
			bool value4 = string.Equals(value3.ToString(), "1", StringComparison.Ordinal);
			Debug($"query_dispatch begin: {request.Method} {request.Scheme}://{request.Host}{request.PathBase}{request.Path}{request.QueryString} from {value}:{remotePort} ua=\"{value2}\"");
			Debug($"query_dispatch format: is_new_format={value4}");
			string key;
			foreach (KeyValuePair<string, StringValues> item in request.Headers.OrderBy<KeyValuePair<string, StringValues>, string>((KeyValuePair<string, StringValues> x) => x.Key, StringComparer.OrdinalIgnoreCase))
			{
				item.Deconstruct(out key, out value3);
				string text = key;
				StringValues stringValues = value3;
				if (text.Equals("Authorization", StringComparison.OrdinalIgnoreCase) || text.Equals("Cookie", StringComparison.OrdinalIgnoreCase))
				{
					Debug("query_dispatch header: " + text + "=<redacted>");
				}
				else
				{
					Debug("query_dispatch header: " + text + "=" + stringValues);
				}
			}
			foreach (KeyValuePair<string, StringValues> item2 in request.Query.OrderBy<KeyValuePair<string, StringValues>, string>((KeyValuePair<string, StringValues> x) => x.Key, StringComparer.OrdinalIgnoreCase))
			{
				item2.Deconstruct(out key, out value3);
				string text2 = key;
				StringValues stringValues2 = value3;
				Debug("query_dispatch query: " + text2 + "=" + stringValues2);
			}
			Debug($"query_dispatch config: RunDispatch={Config.ServerOption.ServerConfig.RunDispatch}, RunGateway={Config.ServerOption.ServerConfig.RunGateway}, Regions={Config.ServerOption.ServerConfig.Regions.Count}");
		}
		catch (Exception e)
		{
			Debug("query_dispatch debug prelude failed", e);
		}
		Dispatch dispatch = new Dispatch();
		if (Config.ServerOption.ServerConfig.RunGateway)
		{
			dispatch.RegionList.Add(new RegionInfo
			{
				Name = Config.GameServer.GameServerId,
				Title = Config.GameServer.GameServerName,
				DispatchUrl = publicBaseUrl + "/query_gateway",
				EnvType = "9",
				DisplayName = Config.GameServer.GameServerName
			});
		}
		foreach (ServerRegion region in Config.ServerOption.ServerConfig.Regions)
		{
			dispatch.RegionList.Add(new RegionInfo
			{
				Name = region.GameServerId,
				Title = region.GameServerName,
				DisplayName = region.GameServerName,
				EnvType = region.EnvType.ToString(),
				DispatchUrl = region.GateWayAddress
			});
		}
		Logger.Info("Client request: query_dispatch");
		byte[] array = dispatch.ToByteArray();
		string text3 = Convert.ToBase64String(array);
		Debug($"query_dispatch result: regionCount={dispatch.RegionList.Count}, protoBytes={array.Length}, base64Length={text3.Length}");
		foreach (RegionInfo region2 in dispatch.RegionList)
		{
			Debug($"query_dispatch region: name={region2.Name} env={region2.EnvType} display={region2.DisplayName} url={region2.DispatchUrl}");
		}
		return Content(text3, "text/plain");
	}

	private string GetPublicBaseUrl()
	{
		HttpRequest request = base.HttpContext.Request;
		string value = request.Host.Value;
		return $"{request.Scheme}://{value}{request.PathBase}".TrimEnd('/');
	}

	[HttpPost("/account/risky/api/check")]
	public ContentResult RiskyCheck()
	{
		return new ContentResult
		{
			Content = "{\"retcode\":0,\"message\":\"OK\",\"data\":{\"id\":\"none\",\"action\":\"ACTION_NONE\",\"geetest\":null}}",
			ContentType = "application/json"
		};
	}

	[HttpPost("/hkrpg_global/mdk/shield/api/login")]
	[HttpPost("/{gameKey}/mdk/shield/api/login")]
	public JsonResult Login([FromBody] LoginReqJson req)
	{
		Debug($"shield login: account={req.account} is_crypto={req.is_crypto}");
		bool decryptRequested = req.is_crypto || Config.WebSecurity.EnableRsaLoginDecrypt;
		var (account, password) = LoginCryptoHelper.TryDecryptCredentials(req.account, req.password, decryptRequested);
		return new UsernameLoginHandler().Handle(account, password, req.is_crypto);
	}

	[HttpPost("/hkrpg_global/account/ma-passport/api/appLoginByPassword")]
	[HttpPost("/{gameKey}/account/ma-passport/api/appLoginByPassword")]
	public JsonResult Login([FromBody] NewLoginReqJson req)
	{
		Debug("appLoginByPassword: account=" + req.account);
		var (account, password) = LoginCryptoHelper.TryDecryptCredentials(req.account, req.password, Config.WebSecurity.EnableRsaLoginDecrypt);
		return new NewUsernameLoginHandler().Handle(account, password);
	}

	[HttpPost("/hkrpg_global/mdk/shield/api/verify")]
	[HttpPost("/{gameKey}/mdk/shield/api/verify")]
	public JsonResult Verify([FromBody] VerifyReqJson req)
	{
		Debug($"shield verify: uid={req.uid} token_len={req.token?.Length ?? 0}");
		return new TokenLoginHandler().Handle(req.uid, req.token);
	}

	[HttpPost("/hkrpg_global/combo/granter/login/v2/login")]
	[HttpPost("/{gameKey}/combo/granter/login/v2/login")]
	public JsonResult LoginV2([FromBody] LoginV2ReqJson req)
	{
		Debug($"combo login v2: app_id={req.app_id} channel_id={req.channel_id} data_len={req.data?.Length ?? 0}");
		return new ComboTokenGranterHandler().Handle(req.app_id, req.channel_id, req.data, req.device, req.sign);
	}

	[HttpPost("/account/ma-cn-passport/app/loginByPassword")]
	public ContentResult NewLogin([FromBody] NewLoginReqJson req)
	{
		Debug("ma loginByPassword: account=" + req.account);
		var (account, password) = LoginCryptoHelper.TryDecryptCredentials(req.account, req.password, Config.WebSecurity.EnableRsaLoginDecrypt);
		return new NewUsernameLoginHandler().HandleLegacy(account, password);
	}

	[HttpPost("/account/ma-cn-session/app/verify")]
	public ContentResult NewVerify([FromBody] VerifySTokenReqJson req)
	{
		Debug("ma verify: mid=" + req.mid + ", token=" + req.token.token);
		return new NewTokenLoginHandler().Handle(req.mid, req.token.token);
	}

	[HttpGet("/hkrpg_global/combo/granter/api/getConfig")]
	[HttpGet("/{gameKey}/combo/granter/api/getConfig")]
	public ContentResult GetConfig()
	{
		return new ContentResult
		{
			Content = "{\"retcode\":0,\"message\":\"OK\",\"data\":{\"protocol\":true,\"qr_enabled\":false,\"log_level\":\"INFO\",\"announce_url\":\"\",\"push_alias_type\":0,\"disable_ysdk_guard\":true,\"enable_announce_pic_popup\":false,\"app_name\":\"崩\ufffd??RPG\",\"qr_enabled_apps\":{\"bbs\":false,\"cloud\":false},\"qr_app_icons\":{\"app\":\"\",\"bbs\":\"\",\"cloud\":\"\"},\"qr_cloud_display_name\":\"\",\"enable_user_center\":true,\"functional_switch_configs\":{}}}",
			ContentType = "application/json"
		};
	}

	[HttpGet("/hkrpg_global/combo/red_dot/list")]
	[HttpPost("/hkrpg_global/combo/red_dot/list")]
	[HttpGet("/{gameKey}/combo/red_dot/list")]
	[HttpPost("/{gameKey}/combo/red_dot/list")]
	public ContentResult RedDot()
	{
		return new ContentResult
		{
			Content = "{\"retcode\":0,\"message\":\"OK\",\"data\":{\"infos\":[]}}",
			ContentType = "application/json"
		};
	}

	[HttpGet("/common/hkrpg_global/announcement/api/getAlertAnn")]
	[HttpGet("/common/{gameKey}/announcement/api/getAlertAnn")]
	public ContentResult AlertAnn()
	{
		return new ContentResult
		{
			Content = "{\"retcode\":0,\"message\":\"OK\",\"data\":{\"alert\":false,\"alert_id\":0,\"remind\":false,\"extra_remind\":false}}",
			ContentType = "application/json"
		};
	}

	[HttpGet("/common/hkrpg_global/announcement/api/getAlertPic")]
	[HttpGet("/common/{gameKey}/announcement/api/getAlertPic")]
	public ContentResult AlertPic()
	{
		return new ContentResult
		{
			Content = "{\"retcode\":0,\"message\":\"OK\",\"data\":{\"total\":0,\"list\":[]}}",
			ContentType = "application/json"
		};
	}

	[HttpGet("/hkrpg_global/mdk/shield/api/loadConfig")]
	[HttpGet("/{gameKey}/mdk/shield/api/loadConfig")]
	public ContentResult LoadConfig()
	{
		return new ContentResult
		{
			Content = "{\"retcode\":0,\"message\":\"OK\",\"data\":{\"id\":24,\"game_key\":\"hkrpg_global\",\"client\":\"PC\",\"identity\":\"I_IDENTITY\",\"guest\":false,\"ignore_versions\":\"\",\"scene\":\"S_NORMAL\",\"name\":\"崩\ufffd??RPG\",\"disable_regist\":false,\"enable_email_captcha\":false,\"thirdparty\":[\"fb\",\"tw\",\"gl\",\"ap\"],\"disable_mmt\":false,\"server_guest\":false,\"thirdparty_ignore\":{},\"enable_ps_bind_account\":false,\"thirdparty_login_configs\":{\"tw\":{\"token_type\":\"TK_GAME_TOKEN\",\"game_token_expires_in\":2592000},\"ap\":{\"token_type\":\"TK_GAME_TOKEN\",\"game_token_expires_in\":604800},\"fb\":{\"token_type\":\"TK_GAME_TOKEN\",\"game_token_expires_in\":2592000},\"gl\":{\"token_type\":\"TK_GAME_TOKEN\",\"game_token_expires_in\":604800}},\"initialize_firebase\":false,\"bbs_auth_login\":false,\"bbs_auth_login_ignore\":[],\"fetch_instance_id\":false,\"enable_flash_login\":false}}",
			ContentType = "application/json"
		};
	}

	[HttpPost("/hkrpg_global/combo/granter/api/compareProtocolVersion")]
	[HttpPost("/{gameKey}/combo/granter/api/compareProtocolVersion")]
	public ContentResult CompareProtocolVer()
	{
		return new ContentResult
		{
			Content = "{\"retcode\":0,\"message\":\"OK\",\"data\":{\"modified\":false,\"protocol\":null}}",
			ContentType = "application/json"
		};
	}

	[HttpGet("/hkrpg_global/mdk/agreement/api/getAgreementInfos")]
	[HttpGet("/{gameKey}/mdk/agreement/api/getAgreementInfos")]
	public ContentResult GetAgreementInfo()
	{
		return new ContentResult
		{
			Content = "{\"retcode\":0,\"message\":\"OK\",\"data\":{\"marketing_agreements\":[]}}",
			ContentType = "application/json"
		};
	}

	[HttpGet("/combo/box/api/config/sdk/combo")]
	public ContentResult Combo()
	{
		return new ContentResult
		{
			Content = "{\"retcode\":0,\"message\":\"OK\",\"data\":{\"vals\":{\"kibana_pc_config\":\"{ \\\"enable\\\": 0, \\\"level\\\": \\\"Info\\\",\\\"modules\\\": [\\\"download\\\"] }\\n\",\"network_report_config\":\"{ \\\"enable\\\": 0, \\\"status_codes\\\": [206], \\\"url_paths\\\": [\\\"dataUpload\\\", \\\"red_dot\\\"] }\\n\",\"list_price_tierv2_enable\":\"false\\n\",\"pay_payco_centered_host\":\"bill.payco.com\",\"telemetry_config\":\"{\\n \\\"dataupload_enable\\\": 0,\\n}\",\"enable_web_dpi\":\"true\"}}}",
			ContentType = "application/json"
		};
	}

	[HttpGet("/combo/box/api/config/sw/precache")]
	public ContentResult Precache()
	{
		return new ContentResult
		{
			Content = "{\"retcode\":0,\"message\":\"OK\",\"data\":{\"vals\":{\"url\":\"\",\"enable\":\"false\"}}}",
			ContentType = "application/json"
		};
	}

	[HttpGet("/device-fp/api/getFp")]
	public JsonResult GetFp([FromQuery] string device_fp)
	{
		return new FingerprintHandler().GetFp(device_fp);
	}

	[HttpGet("/device-fp/api/getExtList")]
	public ContentResult GetExtList()
	{
		return new ContentResult
		{
			Content = "{\"retcode\":0,\"message\":\"OK\",\"data\":{\"code\":200,\"msg\":\"ok\",\"ext_list\":[],\"pkg_list\":[],\"pkg_str\":\"/vK5WTh5SS3SAj8Zm0qPWg==\"}}",
			ContentType = "application/json"
		};
	}

	[HttpPost("/data_abtest_api/config/experiment/list")]
	public ContentResult GetExperimentList()
	{
		return new ContentResult
		{
			Content = "{\"retcode\":0,\"success\":true,\"message\":\"\",\"data\":[{\"code\":1000,\"type\":2,\"config_id\":\"14\",\"period_id\":\"6125_197\",\"version\":\"1\",\"configs\":{\"cardType\":\"direct\"}}]}",
			ContentType = "application/json"
		};
	}
}
