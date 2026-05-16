using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using March7thHoney.Command;
using March7thHoney.Command.Command;
using March7thHoney.Configuration;
using March7thHoney.Data;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Player;
using March7thHoney.Enums;
using March7thHoney.GameServer.Command;
using March7thHoney.GameServer.Game.Challenge.Definitions;
using March7thHoney.GameServer.Game.Mission;
using March7thHoney.GameServer.Game.Raid;
using March7thHoney.GameServer.Plugin;
using March7thHoney.GameServer.Server;
using March7thHoney.GameServer.Server.Packet;
using March7thHoney.Internationalization;
using March7thHoney.Kcp;
using March7thHoney.Kcp.KcpSharp;
using March7thHoney.Program.Generator;
using March7thHoney.Program.Handbook;
using March7thHoney.Util;
using March7thHoney.Util.License;
using March7thHoney.WebServer;
using March7thHoney.WebServer.Server;

namespace March7thHoney.Program.Program;

public class EntryPoint
{
	private static readonly Logger Logger = new Logger("Program");

	public static readonly DatabaseHelper DatabaseHelper = new DatabaseHelper();

	public static readonly Listener Listener = new Listener();

	public static readonly CommandManager CommandManager = new CommandManager();

	public static async Task Main(string[] args)
	{
		bool flag = false;
		IConsole.InitConsole();
		IConsole.RedrawInput(IConsole.Input);
		AppDomain.CurrentDomain.ProcessExit += delegate
		{
			Logger.Info(I18NManager.Translate("Server.ServerInfo.Shutdown"));
			PerformCleanup();
		};
		AppDomain.CurrentDomain.UnhandledException += delegate(object obj, UnhandledExceptionEventArgs arg)
		{
			Logger.Error(I18NManager.Translate("Server.ServerInfo.UnhandledException", obj.GetType().Name), (Exception)arg.ExceptionObject);
			Logger.Info(I18NManager.Translate("Server.ServerInfo.Shutdown"));
			PerformCleanup();
			Environment.Exit(1);
		};
		Console.CancelKeyPress += delegate(object? _, ConsoleCancelEventArgs eventArgs)
		{
			Logger.Info(I18NManager.Translate("Server.ServerInfo.CancelKeyPressed"));
			eventArgs.Cancel = true;
			Environment.Exit(0);
		};
		DateTime time = DateTime.Now;
		DirectoryInfo directoryInfo = new DirectoryInfo(GetConfig().Path.LogPath);
		if (directoryInfo.Exists)
		{
			List<string> list = new List<string>();
			FileInfo[] array = directoryInfo.GetFiles().ToArray();
			foreach (FileInfo fileInfo in array)
			{
				if (!fileInfo.Name.EndsWith(".log") || fileInfo.Name.EndsWith("-debug.log") || list.Contains(fileInfo.Name))
				{
					continue;
				}
				string text = fileInfo.Name.Replace(".log", "");
				string text2 = text + "-debug";
				FileInfo fileInfo2 = directoryInfo.GetFiles(text2 + ".log").FirstOrDefault();
				if (!fileInfo.Exists)
				{
					continue;
				}
				string text3 = text + ".zip";
				FileInfo fileInfo3 = new FileInfo(GetConfig().Path.LogPath + "/" + text3);
				if (fileInfo3.Exists)
				{
					fileInfo3.Delete();
				}
				using (ZipArchive destination = ZipFile.Open(fileInfo3.FullName, ZipArchiveMode.Create))
				{
					destination.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name);
					if (fileInfo2 != null && fileInfo2.Exists)
					{
						destination.CreateEntryFromFile(fileInfo2.FullName, fileInfo2.Name);
					}
				}
				fileInfo.Delete();
				fileInfo2?.Delete();
				list.Add(fileInfo.Name);
				list.Add(fileInfo2?.Name ?? "");
			}
		}
		int num2 = 0;
		FileInfo fileInfo4;
		FileInfo fileInfo5;
		do
		{
			fileInfo4 = new FileInfo(GetConfig().Path.LogPath + $"/{DateTime.Now:yyyy-MM-dd}-{++num2}.log");
			fileInfo5 = new FileInfo(GetConfig().Path.LogPath + $"/{DateTime.Now:yyyy-MM-dd}-{num2}.zip");
		}
		while (fileInfo4 == null || fileInfo4.Exists || fileInfo4.Directory == null || fileInfo5 == null || fileInfo5.Exists || fileInfo5.Directory == null);
		fileInfo4.Directory.Create();
		FileInfo debugLogFile = new FileInfo(GetConfig().Path.LogPath + $"/{DateTime.Now:yyyy-MM-dd}-{num2}-debug.log");
		March7thHoney.Util.Logger.SetLogFile(fileInfo4);
		March7thHoney.Util.Logger.SetDebugLogFile(debugLogFile);
		try
		{
			ConfigManager.LoadConfig(flag);
		}
		catch (Exception e)
		{
			Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToLoadItem", I18NManager.Translate("Word.Config")), e);
			Console.ReadLine();
			return;
		}
		try
		{
			I18NManager.LoadLanguage();
		}
		catch (Exception e2)
		{
			Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToLoadItem", I18NManager.Translate("Word.Language")), e2);
			Console.ReadLine();
			return;
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.StartingServer"));
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.Config")));
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.Language")));
		ConfigManager.Logger.Info(I18NManager.Translate("Server.ServerInfo.CurrentVersion", "4.2.0"));
		if (flag)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.PublicModeEnabled"));
			if (!LicenseManager.ValidateInPublicMode())
			{
				Logger.Warn(I18NManager.Translate("Server.ServerInfo.PublicModeValidationFailed"));
				if (!Console.IsInputRedirected)
				{
					Console.WriteLine();
					Console.WriteLine("Press Enter to close...");
					Console.ReadLine();
				}
				return;
			}
		}
		try
		{
			Task.Run((Action)DatabaseHelper.Initialize);
			while (!March7thHoney.Database.DatabaseHelper.LoadAccount)
			{
				Thread.Sleep(100);
			}
			Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItem", I18NManager.Translate("Word.DatabaseAccount")));
		}
		catch (Exception e3)
		{
			Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToLoadItem", I18NManager.Translate("Word.Database")), e3);
			Console.ReadLine();
			return;
		}
		HandlerManager.Init();
		if (ConfigManager.Config.GameServer.UsePacketEncryption)
		{
			Crypto.ClientSecretKey = Crypto.InitEc2b();
			if (Crypto.ClientSecretKey == null)
			{
				ConfigManager.Config.GameServer.UsePacketEncryption = false;
			}
		}
		Logger.Warn(I18NManager.Translate("Server.ServerInfo.WaitForAllDone"));
		WebProgram.Main(Array.Empty<string>(), GetConfig().HttpServer.Port, GetConfig().HttpServer.GetBindDisplayAddress());
		Logger.Info(I18NManager.Translate("Server.ServerInfo.ServerRunning", I18NManager.Translate("Word.Dispatch"), GetConfig().HttpServer.GetDisplayAddress()));
		if (ConfigManager.Config.ServerOption.ServerConfig.RunGateway)
		{
			March7thHoneyListener.CreateConnection = (KcpConversation conversation, IPEndPoint remote) => new Connection(conversation, remote);
			March7thHoneyListener.StartListener();
		}
		GenerateLogMap();
		if (ConfigManager.Config.ServerOption.ServerConfig.RunGateway)
		{
			try
			{
				bool flag2 = false;
				if (File.Exists(ResourceCache.CachePath))
				{
					if (ConfigManager.Config.ServerOption.UseCache)
					{
						Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.Cache")));
						flag2 = ResourceCache.LoadCache();
						if (!flag2)
						{
							ResourceCache.ClearGameData();
							Logger.Warn(I18NManager.Translate("Server.ServerInfo.CacheLoadFailed"));
						}
					}
					else
					{
						File.Delete(ResourceCache.CachePath);
						Logger.Warn(I18NManager.Translate("Server.ServerInfo.CacheLoadSkip"));
					}
				}
				if (!flag2)
				{
					Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.GameData")));
					ResourceManager.LoadGameData();
					if (ConfigManager.Config.ServerOption.UseCache && ResourceCache.IsComplete)
					{
						Logger.Warn(I18NManager.Translate("Server.ServerInfo.WaitingItem", I18NManager.Translate("Word.Cache")));
						ResourceCache.SaveCache();
					}
				}
			}
			catch (Exception e4)
			{
				Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToLoadItem", I18NManager.Translate("Word.GameData")), e4);
				Console.ReadLine();
				return;
			}
			if (args.Contains("-generate-tourn"))
			{
				TournRoomGenerator.GenerateFile("RogueTournRoom.json");
				return;
			}
		}
		try
		{
			CommandManager.RegisterCommands();
		}
		catch (Exception e5)
		{
			Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToInitializeItem", I18NManager.Translate("Word.Command")), e5);
			Console.ReadLine();
			return;
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.Plugin")));
		try
		{
			PluginManager.LoadPlugins();
		}
		catch (Exception e6)
		{
			Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToLoadItem", I18NManager.Translate("Word.Plugin")), e6);
			Console.ReadLine();
			return;
		}
		CommandExecutor.OnRunCommand += delegate(ICommandSender sender, string input)
		{
			CommandManager.HandleCommand(input, sender);
		};
		MuipManager.OnExecuteCommand += CommandManager.HandleCommand;
		MuipManager.OnGetServerInformation += delegate(Dictionary<int, PlayerData> x)
		{
			foreach (March7thHoneyConnection value in March7thHoneyListener.Connections.Values)
			{
				if ((value as Connection)?.Player != null)
				{
					x.Add((value as Connection).Player.Uid, (value as Connection).Player.Data);
				}
			}
		};
		MuipManager.OnGetPlayerStatus += delegate(int uid, out PlayerStatusEnum status, out PlayerSubStatusEnum subStatus)
		{
			subStatus = PlayerSubStatusEnum.None;
			foreach (March7thHoneyConnection value2 in March7thHoneyListener.Connections.Values)
			{
				if ((value2 as Connection).Player != null && (value2 as Connection).Player.Uid == uid)
				{
					if ((value2 as Connection).Player.ChallengeManager?.ChallengeInstance is BaseLegacyChallengeInstance baseLegacyChallengeInstance)
					{
						status = PlayerStatusEnum.Challenge;
						if (baseLegacyChallengeInstance.Config.StoryExcel != null)
						{
							status = PlayerStatusEnum.ChallengeStory;
						}
						else if (baseLegacyChallengeInstance.Config.BossExcel != null)
						{
							status = PlayerStatusEnum.ChallengeBoss;
						}
					}
					else
					{
						RaidManager? raidManager = (value2 as Connection).Player.RaidManager;
						if (raidManager == null || raidManager.RaidData.CurRaidId != 0)
						{
							status = PlayerStatusEnum.Raid;
						}
						else
						{
							StoryLineManager? storyLineManager = (value2 as Connection).Player.StoryLineManager;
							if (storyLineManager == null || storyLineManager.StoryLineData.CurStoryLineId != 0)
							{
								status = PlayerStatusEnum.StoryLine;
							}
							else
							{
								status = PlayerStatusEnum.Explore;
							}
						}
					}
					if ((value2 as Connection).Player.BattleInstance != null)
					{
						subStatus = PlayerSubStatusEnum.Battle;
					}
					return;
				}
			}
			status = PlayerStatusEnum.Offline;
		};
		if (ConfigManager.Config.ServerOption.ServerConfig.RunGateway)
		{
			new Task(HandbookGenerator.GenerateAll).Start();
		}
		if (!March7thHoney.Database.DatabaseHelper.LoadAllData)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.WaitForAllDone"));
			await Task.Run(delegate
			{
				while (!March7thHoney.Database.DatabaseHelper.LoadAllData)
				{
					Thread.Sleep(100);
				}
			}).WaitAsync(default(CancellationToken));
			Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItem", I18NManager.Translate("Word.Database")));
		}
		ServerUtils.InitializeHandlers();
		bool flag3 = false;
		foreach (AvatarData item in March7thHoney.Database.DatabaseHelper.GetAllInstanceFromMap<AvatarData>())
		{
			if (item.DatabaseVersion == "20250430")
			{
				continue;
			}
			foreach (OldAvatarInfo avatar in item.Avatars)
			{
				FormalAvatarInfo formalAvatarInfo = new FormalAvatarInfo
				{
					BaseAvatarId = avatar.AvatarId,
					AvatarId = ((avatar.PathId == 0) ? avatar.AvatarId : avatar.PathId),
					CurrentHp = avatar.CurrentHp,
					CurrentSp = avatar.CurrentSp,
					Exp = avatar.Exp,
					ExtraLineupHp = avatar.ExtraLineupHp,
					ExtraLineupSp = avatar.ExtraLineupSp,
					IsMarked = avatar.IsMarked,
					Level = avatar.Level,
					Promotion = avatar.Promotion,
					PathInfos = new Dictionary<int, PathInfo>()
				};
				foreach (KeyValuePair<int, PathInfo> pathInfo in avatar.PathInfoes)
				{
					if (pathInfo.Value.PathId == 0)
					{
						pathInfo.Value.PathId = avatar.AvatarId;
					}
					formalAvatarInfo.PathInfos.Add(pathInfo.Value.PathId, new PathInfo(pathInfo.Value.PathId)
					{
						PathId = pathInfo.Value.PathId,
						EquipId = pathInfo.Value.EquipId,
						Rank = pathInfo.Value.Rank,
						Relic = pathInfo.Value.Relic,
						Skin = pathInfo.Value.Skin,
						EnhanceInfos = { 
						{
							0,
							new EnhanceInfo(0)
							{
								SkillTree = (avatar.SkillTreeExtra.GetValueOrDefault(pathInfo.Value.PathId) ?? new Dictionary<int, int>())
							}
						} }
					});
				}
				item.FormalAvatars.Add(formalAvatarInfo);
			}
			item.DatabaseVersion = "20250430";
			flag3 = true;
			March7thHoney.Database.DatabaseHelper.ToSaveUidList.Add(item.Uid);
		}
		if (flag3)
		{
			Logger.Info(I18NManager.Translate("Server.ServerInfo.UpdatedItem", I18NManager.Translate("Word.Database")));
			DatabaseHelper.SaveDatabase();
		}
		if (args.Contains("--upgrade-database"))
		{
			DatabaseHelper.UpgradeDatabase();
		}
		if (args.Contains("--move"))
		{
			DatabaseHelper.MoveFromSqlite();
		}
		TimeSpan timeSpan = DateTime.Now - time;
		Logger.Info(I18NManager.Translate("Server.ServerInfo.ServerStarted", Math.Round(timeSpan.TotalSeconds, 2).ToString(CultureInfo.InvariantCulture)));
		if (GetConfig().ServerOption.EnableMission)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.MissionEnabled"));
		}
		ResourceManager.IsLoaded = true;
		IConsole.OnConsoleExcuteCommand += delegate(string command)
		{
			CommandManager.HandleCommand(command, new ConsoleCommandSender(Logger));
			IConsole.RedrawInput(IConsole.Input);
		};
		IConsole.ListenConsole();
	}

	public static ConfigContainer GetConfig()
	{
		return ConfigManager.Config;
	}

	private static void PerformCleanup()
	{
		PluginManager.UnloadPlugins();
		March7thHoneyListener.Connections.Values.ToList().ForEach(delegate(March7thHoneyConnection x)
		{
			x.Stop();
		});
		March7thHoney.Database.DatabaseHelper.SaveThread?.Interrupt();
		DatabaseHelper.SaveDatabase();
	}

	private static void GenerateLogMap()
	{
		foreach (FieldInfo item in (from x in typeof(CmdIds).GetFields()
			where x.FieldType == typeof(int)
			select x).ToList())
		{
			string name = item.Name;
			int key = (int)item.GetValue(null);
			March7thHoneyConnection.LogMap.TryAdd(key, name);
		}
	}
}
