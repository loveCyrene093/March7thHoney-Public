using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Lineup;
using March7thHoney.Database.Player;
using March7thHoney.Database.Quests;
using March7thHoney.Enums;
using March7thHoney.Util;
using March7thHoney.WebServer.Response;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.X509;

namespace March7thHoney.WebServer.Server;

public static class MuipManager
{
	public delegate void ExecuteCommandDelegate(string message, MuipCommandSender sender);

	public delegate void GetPlayerStatusDelegate(int uid, out PlayerStatusEnum status, out PlayerSubStatusEnum subStatus);

	public delegate void ServerInformationDelegate(Dictionary<int, PlayerData> resultData);

	private static readonly Logger logger = Logger.GetByClassName();

	public static string RsaPublicKey { get; private set; } = "";

	public static string RsaPrivateKey { get; private set; } = "";

	public static Dictionary<string, MuipSession> Sessions { get; } = new Dictionary<string, MuipSession>();

	public static event ExecuteCommandDelegate? OnExecuteCommand;

	public static event ServerInformationDelegate? OnGetServerInformation;

	public static event GetPlayerStatusDelegate? OnGetPlayerStatus;

	public static CreateSessionResponse CreateSession(string keyType)
	{
		if (ConfigManager.Config.MuipServer.AdminKey == "")
		{
			return new CreateSessionResponse(1, "This function is not enabled in this server!", null);
		}
		MuipSession muipSession = new MuipSession
		{
			SessionId = Guid.NewGuid().ToString(),
			RsaPublicKey = GetRsaKeyPair().Item1,
			ExpireTimeStamp = DateTime.Now.AddMinutes(15.0).ToUnixSec(),
			IsAdmin = true
		};
		if (keyType == "PEM")
		{
			muipSession.RsaPublicKey = XMLToPEM_Pub(muipSession.RsaPublicKey);
		}
		Sessions.Add(muipSession.SessionId, muipSession);
		CreateSessionData data = new CreateSessionData
		{
			RsaPublicKey = muipSession.RsaPublicKey,
			SessionId = muipSession.SessionId,
			ExpireTimeStamp = muipSession.ExpireTimeStamp
		};
		return new CreateSessionResponse(0, "Created!", data);
	}

	public static AuthAdminKeyResponse AuthAdmin(string sessionId, string key)
	{
		if (Sessions.TryGetValue(sessionId, out MuipSession value))
		{
			MuipSession muipSession = value;
			if (muipSession.ExpireTimeStamp < DateTime.Now.ToUnixSec())
			{
				Sessions.Remove(sessionId);
				return new AuthAdminKeyResponse(1, "Session has expired!", null);
			}
			if (DecodeWithRsaFallback(key) != ConfigManager.Config.MuipServer.AdminKey)
			{
				return new AuthAdminKeyResponse(2, "Admin key is invalid!", null);
			}
			muipSession.IsAuthorized = true;
			AuthAdminKeyData data = new AuthAdminKeyData
			{
				SessionId = muipSession.SessionId,
				ExpireTimeStamp = muipSession.ExpireTimeStamp
			};
			return new AuthAdminKeyResponse(0, "Authorized admin key successfully!", data);
		}
		return new AuthAdminKeyResponse(4, "Session not found!", null);
	}

	public static MuipSession? GetSession(string sessionId)
	{
		if (Sessions.TryGetValue(sessionId, out MuipSession value))
		{
			MuipSession muipSession = value;
			if (muipSession.ExpireTimeStamp < DateTime.Now.ToUnixSec())
			{
				Sessions.Remove(sessionId);
				return null;
			}
			return muipSession;
		}
		return null;
	}

	public static ExecuteCommandResponse ExecuteCommand(string sessionId, string command, int targetUid)
	{
		if (Sessions.TryGetValue(sessionId, out MuipSession value))
		{
			MuipSession session = value;
			if (session.ExpireTimeStamp < DateTime.Now.ToUnixSec())
			{
				Sessions.Remove(sessionId);
				return new ExecuteCommandResponse(1, "Session has expired!");
			}
			if (!session.IsAuthorized)
			{
				return new ExecuteCommandResponse(4, "Not authorized!");
			}
			string commandStr = DecodeWithRsaFallback(command);
			if (string.IsNullOrWhiteSpace(commandStr))
			{
				return new ExecuteCommandResponse(3, "Wrong encrypted key");
			}
			logger.Info($"SessionId: {sessionId}, UID: {targetUid}, ExecuteCommand: {commandStr}");
			string returnStr = "";
			Task.Run(delegate
			{
				MuipManager.OnExecuteCommand?.Invoke(commandStr, new MuipCommandSender(session, delegate(string msg)
				{
					returnStr = returnStr + msg + "\r\n";
				})
				{
					SenderUid = targetUid
				});
			}).Wait();
			return new ExecuteCommandResponse(0, "Success", new ExecuteCommandData
			{
				SessionId = sessionId,
				Message = Convert.ToBase64String(Encoding.UTF8.GetBytes(returnStr))
			});
		}
		return new ExecuteCommandResponse(2, "Session not found!");
	}

	public static ServerInformationResponse GetInformation(string sessionId)
	{
		if (Sessions.TryGetValue(sessionId, out MuipSession value))
		{
			MuipSession muipSession = value;
			if (muipSession.ExpireTimeStamp < DateTime.Now.ToUnixSec())
			{
				Sessions.Remove(sessionId);
				return new ServerInformationResponse(1, "Session has expired!");
			}
			if (!muipSession.IsAuthorized)
			{
				return new ServerInformationResponse(3, "Not authorized!");
			}
			long workingSet = Process.GetCurrentProcess().WorkingSet64;
			float num = -1f;
			float num2 = -1f;
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				num = GetTotalMemoryWindows();
				num2 = GetAvailableMemoryWindows();
			}
			else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
			{
				num = GetTotalMemoryLinux();
				num2 = GetAvailableMemoryLinux();
			}
			Dictionary<int, PlayerData> result = new Dictionary<int, PlayerData>();
			Task.Run(delegate
			{
				MuipManager.OnGetServerInformation?.Invoke(result);
			}).Wait();
			return new ServerInformationResponse(0, "Success", new ServerInformationData
			{
				ServerTime = DateTime.Now.ToUnixSec(),
				MaxMemory = num,
				ProgramUsedMemory = workingSet / 1024 / 1024,
				UsedMemory = num - num2,
				OnlinePlayers = result.Values.Select((PlayerData x) => new SimplePlayerInformationData
				{
					Name = (x.Name ?? ""),
					HeadIconId = x.HeadIcon,
					Uid = x.Uid
				}).ToList()
			});
		}
		return new ServerInformationResponse(2, "Session not found!");
	}

	public static PlayerInformationResponse GetPlayerInformation(string sessionId, int uid)
	{
		if (Sessions.TryGetValue(sessionId, out MuipSession value))
		{
			MuipSession muipSession = value;
			if (muipSession.ExpireTimeStamp < DateTime.Now.ToUnixSec())
			{
				Sessions.Remove(sessionId);
				return new PlayerInformationResponse(1, "Session has expired!");
			}
			if (!muipSession.IsAuthorized)
			{
				return new PlayerInformationResponse(4, "Not authorized!");
			}
			PlayerData player = DatabaseHelper.Instance?.GetInstance<PlayerData>(uid);
			if (player == null)
			{
				return new PlayerInformationResponse(2, "Player not exist!");
			}
			PlayerStatusEnum status = PlayerStatusEnum.Offline;
			PlayerSubStatusEnum subStatus = PlayerSubStatusEnum.None;
			Task.Run(delegate
			{
				MuipManager.OnGetPlayerStatus?.Invoke(player.Uid, out status, out subStatus);
			}).Wait();
			AvatarData instance = DatabaseHelper.Instance.GetInstance<AvatarData>(player.Uid);
			LineupData instance2 = DatabaseHelper.Instance.GetInstance<LineupData>(player.Uid);
			MissionData instance3 = DatabaseHelper.Instance.GetInstance<MissionData>(player.Uid);
			List<int> list = new List<int>();
			int key = ((instance2.CurExtraLineup > 0) ? instance2.CurExtraLineup : instance2.CurLineup);
			instance2.Lineups.TryGetValue(key, out LineupInfo value2);
			if (value2 != null)
			{
				foreach (LineupAvatarInfo item in value2.BaseAvatars ?? new List<LineupAvatarInfo>())
				{
					GameData.AvatarConfigData.TryGetValue(item.BaseAvatarId, out AvatarConfigExcel value3);
					if (value3 != null)
					{
						list.Add(item.BaseAvatarId);
					}
				}
			}
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (int runningSubMissionId in instance3.RunningSubMissionIds)
			{
				SubMissionData valueOrDefault = GameData.SubMissionInfoData.GetValueOrDefault(runningSubMissionId);
				if (valueOrDefault != null)
				{
					if (dictionary.ContainsKey(valueOrDefault.MainMissionId))
					{
						dictionary[valueOrDefault.MainMissionId].Add(valueOrDefault.MissionId);
						continue;
					}
					int mainMissionId = valueOrDefault.MainMissionId;
					int num = 1;
					List<int> list2 = new List<int>(num);
					CollectionsMarshal.SetCount(list2, num);
					CollectionsMarshal.AsSpan(list2)[0] = valueOrDefault.MissionId;
					dictionary[mainMissionId] = list2;
				}
			}
			return new PlayerInformationResponse(0, "Success", new PlayerInformationData
			{
				Uid = player.Uid,
				Name = (player.Name ?? ""),
				Signature = (player.Signature ?? ""),
				Stamina = player.Stamina,
				RecoveryStamina = (int)player.StaminaReserve,
				HeadIconId = player.HeadIcon,
				CurFloorId = player.FloorId,
				CurPlaneId = player.PlaneId,
				AssistAvatarList = instance.AssistAvatars,
				DisplayAvatarList = instance.DisplayAvatars,
				AcceptedMissionList = dictionary,
				FinishedMainMissionIdList = instance3.FinishedMainMissionIds,
				FinishedSubMissionIdList = instance3.FinishedSubMissionIds,
				PlayerStatus = status,
				PlayerSubStatus = subStatus,
				Credit = player.Scoin,
				Jade = player.Hcoin,
				LineupBaseAvatarIdList = list
			});
		}
		return new PlayerInformationResponse(3, "Session not found!");
	}

	private static string DecodeWithRsaFallback(string text)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			return string.Empty;
		}
		try
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(GetRsaKeyPair().Item2);
			byte[] bytes = rSACryptoServiceProvider.Decrypt(Convert.FromBase64String(text), RSAEncryptionPadding.Pkcs1);
			return Encoding.UTF8.GetString(bytes);
		}
		catch
		{
		}
		try
		{
			byte[] bytes2 = Convert.FromBase64String(text);
			string text2 = Encoding.UTF8.GetString(bytes2);
			if (!string.IsNullOrWhiteSpace(text2))
			{
				return text2;
			}
		}
		catch
		{
		}
		return text;
	}

	public static (string, string) GetRsaKeyPair()
	{
		if (string.IsNullOrEmpty(RsaPublicKey) || string.IsNullOrEmpty(RsaPrivateKey))
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
			RsaPublicKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
			RsaPrivateKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
		}
		return (RsaPublicKey, RsaPrivateKey);
	}

	public static string XMLToPEM_Pub(string xmlpubkey)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(xmlpubkey);
		RSAParameters rSAParameters = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: false);
		return Format(Convert.ToBase64String(SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(new RsaKeyParameters(isPrivate: false, new BigInteger(1, rSAParameters.Modulus), new BigInteger(1, rSAParameters.Exponent))).ToAsn1Object().GetDerEncoded()), type: true);
	}

	private static string Format(string key, bool type)
	{
		string text = string.Empty;
		int num = key.Length / 64;
		for (int i = 0; i < num; i++)
		{
			int startIndex = i * 64;
			text = text + key.Substring(startIndex, 64) + "\r\n";
		}
		text += key.Substring(num * 64);
		if (type)
		{
			text = text.Insert(0, "-----BEGIN PUBLIC KEY-----\r\n");
			return text + "\r\n-----END PUBLIC KEY-----";
		}
		text = text.Insert(0, "-----BEGIN PRIVATE KEY-----\r\n");
		return text + "\r\n-----END PRIVATE KEY-----";
	}

	public static float GetTotalMemoryWindows()
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			using ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem").Get().GetEnumerator();
			if (managementObjectEnumerator.MoveNext())
			{
				return Convert.ToUInt64(managementObjectEnumerator.Current["TotalPhysicalMemory"]) / 1024 / 1024;
			}
		}
		return 0f;
	}

	public static float GetAvailableMemoryWindows()
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			return new PerformanceCounter("Memory", "Available MBytes").NextValue();
		}
		return 0f;
	}

	public static float GetTotalMemoryLinux()
	{
		string[] array = File.ReadAllLines("/proc/meminfo");
		foreach (string text in array)
		{
			if (text.StartsWith("MemTotal"))
			{
				return float.Parse(text.Split(':')[1].Trim().Split(' ')[0]) / 1024f;
			}
		}
		return 0f;
	}

	public static float GetAvailableMemoryLinux()
	{
		string[] array = File.ReadAllLines("/proc/meminfo");
		foreach (string text in array)
		{
			if (text.StartsWith("MemAvailable"))
			{
				return float.Parse(text.Split(':')[1].Trim().Split(' ')[0]) / 1024f;
			}
		}
		return 0f;
	}

	public static float GetCpuUsage()
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
		{
			return GetCpuUsageLinux();
		}
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			return GetCpuUsageWindows();
		}
		throw new NotSupportedException("Unsupported OS platform");
	}

	private static float GetCpuUsageLinux()
	{
		string[] array = File.ReadAllLines("/proc/stat")[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
		float num = float.Parse(array[4]);
		float num2 = 0f;
		for (int i = 1; i < array.Length; i++)
		{
			num2 += float.Parse(array[i]);
		}
		return 100f * (1f - num / num2);
	}

	private static float GetCpuUsageWindows()
	{
		if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			throw new PlatformNotSupportedException("PerformanceCounter is only supported on Windows");
		}
		PerformanceCounter performanceCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
		performanceCounter.NextValue();
		Thread.Sleep(1000);
		return performanceCounter.NextValue();
	}

	public static (string ModelName, int Cores, float Frequency) GetCpuDetails()
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
		{
			return GetCpuDetailsLinux();
		}
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			return GetCpuDetailsWindows();
		}
		throw new NotSupportedException("Unsupported OS platform");
	}

	private static (string ModelName, int Cores, float Frequency) GetCpuDetailsLinux()
	{
		string[] array = File.ReadAllLines("/proc/cpuinfo");
		string item = "";
		int item2 = 0;
		float item3 = 0f;
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text.StartsWith("model name"))
			{
				item = text.Split(':')[1].Trim();
			}
			if (text.StartsWith("cpu cores"))
			{
				item2 = int.Parse(text.Split(':')[1].Trim());
			}
			if (text.StartsWith("cpu MHz"))
			{
				item3 = float.Parse(text.Split(':')[1].Trim());
			}
		}
		return (ModelName: item, Cores: item2, Frequency: item3);
	}

	private static (string ModelName, int Cores, float Frequency) GetCpuDetailsWindows()
	{
		if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			throw new PlatformNotSupportedException("ManagementObjectSearcher is only supported on Windows");
		}
		string item = "";
		int item2 = 0;
		float item3 = 0f;
		foreach (ManagementBaseObject item4 in new ManagementObjectSearcher("select * from Win32_Processor").Get())
		{
			item = item4["Name"]?.ToString() ?? "Unknown";
			item2 = int.Parse(item4["NumberOfCores"]?.ToString() ?? "0");
			item3 = float.Parse(item4["MaxClockSpeed"]?.ToString() ?? "0") / 1000f;
		}
		return (ModelName: item, Cores: item2, Frequency: item3);
	}

	public static string GetSystemVersion()
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			return GetWindowsVersion();
		}
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
		{
			return GetLinuxVersion();
		}
		throw new PlatformNotSupportedException("This method only supports Windows and Linux.");
	}

	private static string GetWindowsVersion()
	{
		return Environment.OSVersion.VersionString;
	}

	private static string GetLinuxVersion()
	{
		string result = string.Empty;
		if (File.Exists("/etc/os-release"))
		{
			string[] array = File.ReadAllLines("/etc/os-release");
			foreach (string text in array)
			{
				if (text.StartsWith("PRETTY_NAME"))
				{
					result = text.Split('=')[1].Trim('"');
					break;
				}
			}
		}
		else if (File.Exists("/proc/version"))
		{
			result = File.ReadAllText("/proc/version");
		}
		return result;
	}
}
