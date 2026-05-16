using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Config.AdventureAbility;
using March7thHoney.Data.Config.Character;
using March7thHoney.Data.Config.Rogue;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Config.SummonUnit;
using March7thHoney.Data.Custom;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Rogue;
using March7thHoney.Enums.RogueMagic;
using March7thHoney.Enums.TournRogue;
using March7thHoney.Internationalization;
using March7thHoney.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data;

public class ResourceManager
{
	public static Logger Logger { get; } = new Logger("ResMgr");

	public static bool IsLoaded { get; set; }

	private static void LogPartialMissingSummary(string itemName, int missingCount, List<string> missingFiles)
	{
		if (missingCount <= 0)
		{
			return;
		}
		Logger.Warn($"{itemName} 部分缺失，缺失数量: {missingCount}");
		March7thHoney.Util.Logger.WriteToFile($"[{DateTime.Now:HH:mm:ss}] [ResMgr] WARN {itemName} missing file list start ({missingCount}):");
		foreach (string missingFile in missingFiles)
		{
			March7thHoney.Util.Logger.WriteToFile(missingFile);
		}
		March7thHoney.Util.Logger.WriteToFile($"[{DateTime.Now:HH:mm:ss}] [ResMgr] WARN {itemName} missing file list end");
	}

	public static void LoadGameData()
	{
		LoadExcel();
		Task task = Task.Run((Action)LoadFloorInfo);
		Task task2 = Task.Run((Action)LoadMazeSkill);
		Task task3 = Task.Run((Action)LoadSummonUnit);
		Task task4 = Task.Run(delegate
		{
			LoadMissionInfo();
			LoadSubMissionInfo();
		});
		Task task5 = Task.Run((Action)LoadPerformanceInfo);
		Task task6 = Task.Run((Action)LoadDialogueInfo);
		Task task7 = Task.Run((Action)LoadAdventureModifier);
		Task task8 = Task.Run((Action)LoadLocalPlayer);
		GameData.ActivityConfig = LoadCustomFile<ActivityConfig>("Activity", "ActivityConfig") ?? new ActivityConfig();
		GameData.BannersConfig = LoadCustomFile<BannersConfig>("Banner", "Banners") ?? new BannersConfig();
		GameData.VideoKeysConfig = LoadCustomFile<VideoKeysConfig>("VideoKeys", "VideoKeysConfig") ?? new VideoKeysConfig();
		GameData.QueryProductInfoConfig = LoadCustomFile<QueryProductInfoConfig>("QueryProductInfo", "QueryProductInfoConfig") ?? new QueryProductInfoConfig();
		GameData.SceneRainbowGroupPropertyData = LoadCustomFile<SceneRainbowGroupPropertyConfig>("Scene Rainbow Group Property", "SceneRainbowGroupProperty") ?? new SceneRainbowGroupPropertyConfig();
		GameData.ChallengePeakOverrideConfig = LoadDataFile<ChallengePeakOverrideConfig>("ChallengePeak Override", "ChallengePeak") ?? new ChallengePeakOverrideConfig();
		ApplyChallengePeakOverrides();
		InlineArray8<Task> buffer = default(InlineArray8<Task>);
		buffer[0] = task;
		buffer[1] = task2;
		buffer[2] = task3;
		buffer[3] = task4;
		buffer[4] = task5;
		buffer[5] = task6;
		buffer[6] = task7;
		buffer[7] = task8;
		Task.WaitAll(buffer);
		foreach (AdventureAbilityConfigListInfo value in GameData.AdventureAbilityConfigListData.Values)
		{
			foreach (KeyValuePair<string, AdventureModifierConfig> item in value?.GlobalModifiers ?? new Dictionary<string, AdventureModifierConfig>())
			{
				GameData.AdventureModifierData.Add(item.Key, item.Value);
			}
		}
	}

	public static void LoadExcel()
	{
		Type[] types = Assembly.GetExecutingAssembly().GetTypes();
		List<ExcelResource> list = new List<ExcelResource>();
		foreach (Type item in types.Where((Type x) => x.IsSubclassOf(typeof(ExcelResource))))
		{
			List<ExcelResource> list2 = LoadSingleExcelResource(item);
			if (list2 != null)
			{
				list.AddRange(list2);
			}
		}
		foreach (ExcelResource item2 in list)
		{
			item2.AfterAllDone();
		}
	}

	public static List<T>? LoadSingleExcel<T>(Type cls) where T : ExcelResource, new()
	{
		return LoadSingleExcelResource(cls) as List<T>;
	}

	public static List<ExcelResource>? LoadSingleExcelResource(Type cls)
	{
		ResourceEntity resourceEntity = (ResourceEntity)Attribute.GetCustomAttribute(cls, typeof(ResourceEntity));
		if (resourceEntity == null)
		{
			return null;
		}
		ExcelResource excelResource = (ExcelResource)Activator.CreateInstance(cls);
		int num = 0;
		List<ExcelResource> list = new List<ExcelResource>();
		foreach (string item in resourceEntity.FileName)
		{
			try
			{
				FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ResourcePath + "/ExcelOutput/" + item);
				if (!fileInfo.Exists)
				{
					Logger.Warn(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", item, I18NManager.Translate("Word.NotFound")));
					continue;
				}
				string text = fileInfo.OpenText().ReadToEnd();
				using (JsonTextReader jsonTextReader = new JsonTextReader(new StringReader(text)))
				{
					jsonTextReader.Read();
					switch (jsonTextReader.TokenType)
					{
					case JsonToken.StartArray:
						foreach (JToken item2 in JArray.Parse(text))
						{
							object obj4 = JsonConvert.DeserializeObject(item2.ToString(), cls);
							list.Add((ExcelResource)obj4);
							((ExcelResource)obj4)?.Loaded();
							num++;
						}
						break;
					case JsonToken.StartObject:
						foreach (KeyValuePair<string, JToken> item3 in JObject.Parse(text))
						{
							item3.Deconstruct(out var _, out var value);
							JToken jToken = value;
							object obj = JsonConvert.DeserializeObject(jToken.ToString(), cls);
							ExcelResource obj2 = (ExcelResource)obj;
							if ((obj2 != null && obj2.GetId() == 0) || (ExcelResource)obj == null)
							{
								foreach (KeyValuePair<string, JToken> item4 in JsonConvert.DeserializeObject<JObject>(jToken.ToString()) ?? new JObject())
								{
									object obj3 = JsonConvert.DeserializeObject(item4.Value.ToString(), cls);
									list.Add((ExcelResource)obj3);
									((ExcelResource)obj3)?.Loaded();
									num++;
								}
							}
							else
							{
								list.Add((ExcelResource)obj);
								((ExcelResource)obj).Loaded();
							}
							num++;
						}
						break;
					}
				}
				excelResource.Finalized();
			}
			catch (Exception e)
			{
				ResourceCache.IsComplete = false;
				Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", item, I18NManager.Translate("Word.Error")), e);
			}
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", num.ToString(), cls.Name));
		return list;
	}

	public static void LoadFloorInfo()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.FloorInfo")));
		DirectoryInfo directoryInfo = new DirectoryInfo(ConfigManager.Config.Path.ResourcePath + "/Config/LevelOutput/RuntimeFloor/");
		bool missingGroupInfos = false;
		if (!directoryInfo.Exists)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", I18NManager.Translate("Word.FloorInfo"), ConfigManager.Config.Path.ResourcePath + "/Config/LevelOutput/RuntimeFloor", I18NManager.Translate("Word.FloorMissingResult")));
			return;
		}
		ParallelLoopResult parallelLoopResult = Parallel.ForEach(directoryInfo.GetFiles(), delegate(FileInfo file)
		{
			try
			{
				using FileStream stream = file.OpenRead();
				using StreamReader streamReader = new StreamReader(stream);
				FloorInfo floorInfo = JsonConvert.DeserializeObject<FloorInfo>(streamReader.ReadToEnd());
				string key = file.Name.Substring(0, file.Name.IndexOf('.'));
				if (floorInfo != null)
				{
					GameData.FloorInfoData[key] = floorInfo;
					FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ResourcePath + "/" + floorInfo.NavmapConfigPath);
					if (fileInfo.Exists)
					{
						try
						{
							using FileStream stream2 = fileInfo.OpenRead();
							using StreamReader streamReader2 = new StreamReader(stream2);
							MapInfo mapInfo = JsonConvert.DeserializeObject<MapInfo>(streamReader2.ReadToEnd());
							if (mapInfo != null)
							{
								foreach (AreaInfo area in mapInfo.AreaList)
								{
									foreach (SectionsInfo section in area.MinimapVolume.Sections)
									{
										floorInfo.MapSections.Add(section.ID);
									}
								}
							}
						}
						catch (Exception e)
						{
							ResourceCache.IsComplete = false;
							Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", fileInfo.Name, I18NManager.Translate("Word.Error")), e);
						}
					}
					foreach (FloorGroupInfo groupInstance in floorInfo.GroupInstanceList)
					{
						if (!groupInstance.IsDelete && !groupInstance.GroupPath.Contains("_D100"))
						{
							FileInfo fileInfo2 = new FileInfo(ConfigManager.Config.Path.ResourcePath + "/" + groupInstance.GroupPath);
							if (fileInfo2.Exists)
							{
								try
								{
									using FileStream stream3 = fileInfo2.OpenRead();
									using StreamReader streamReader3 = new StreamReader(stream3);
									GroupInfo groupInfo = JsonConvert.DeserializeObject<GroupInfo>(streamReader3.ReadToEnd());
									if (groupInfo != null)
									{
										groupInfo.Id = groupInstance.ID;
										floorInfo.Groups[groupInstance.ID] = groupInfo;
										FileInfo fileInfo3 = new FileInfo(ConfigManager.Config.Path.ResourcePath + "/" + groupInfo.LevelGraph);
										if (fileInfo3.Exists)
										{
											using FileStream stream4 = fileInfo3.OpenRead();
											using StreamReader streamReader4 = new StreamReader(stream4);
											LevelGraphConfigInfo levelGraphConfig = LevelGraphConfigInfo.LoadFromJsonObject(JObject.Parse(streamReader4.ReadToEnd().Replace("$type", "Type")));
											groupInfo.LevelGraphConfig = levelGraphConfig;
										}
										groupInfo.Load();
									}
								}
								catch (Exception e2)
								{
									ResourceCache.IsComplete = false;
									Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", fileInfo2.Name, I18NManager.Translate("Word.Error")), e2);
								}
							}
						}
					}
					if (floorInfo.Groups.Count == 0)
					{
						missingGroupInfos = true;
					}
					floorInfo.OnLoad();
				}
			}
			catch (Exception e3)
			{
				ResourceCache.IsComplete = false;
				Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", file.Name, I18NManager.Translate("Word.Error")), e3);
			}
		});
		while (!parallelLoopResult.IsCompleted)
		{
			Thread.Sleep(10);
		}
		if (missingGroupInfos)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", I18NManager.Translate("Word.FloorGroupInfo"), ConfigManager.Config.Path.ResourcePath + "/Config/LevelOutput/SharedRuntimeGroup", I18NManager.Translate("Word.FloorGroupMissingResult")));
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", GameData.FloorInfoData.Count.ToString(), I18NManager.Translate("Word.FloorInfo")));
	}

	public static void LoadMissionInfo()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.MissionInfo")));
		if (!new DirectoryInfo(ConfigManager.Config.Path.ResourcePath + "/Config/Level/Mission").Exists)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", I18NManager.Translate("Word.MissionInfo"), ConfigManager.Config.Path.ResourcePath + "/Config/Level/Mission", I18NManager.Translate("Word.Mission")));
			return;
		}
		bool missingMissionInfos = false;
		int missingCount = 0;
		List<string> missingFiles = new List<string>();
		int count = 0;
		ParallelLoopResult parallelLoopResult = Parallel.ForEach<KeyValuePair<int, MainMissionExcel>>(GameData.MainMissionData, delegate(KeyValuePair<int, MainMissionExcel> missionExcel)
		{
			try
			{
				string text = $"{ConfigManager.Config.Path.ResourcePath}/Config/Level/Mission/{missionExcel.Key}/MissionInfo_{missionExcel.Key}.json";
				if (!File.Exists(text))
				{
					missingMissionInfos = true;
					Interlocked.Increment(ref missingCount);
					lock (missingFiles)
					{
						missingFiles.Add(text);
						return;
					}
				}
				MissionInfo missionInfo = JsonConvert.DeserializeObject<MissionInfo>(File.ReadAllText(text));
				string path = $"{ConfigManager.Config.Path.ResourcePath}/Config/Level/Mission/{missionExcel.Key}/MissionInfo_{missionExcel.Key}.partial.json";
				if (missionInfo != null && File.Exists(path))
				{
					try
					{
						MissionInfo missionInfo2 = JsonConvert.DeserializeObject<MissionInfo>(File.ReadAllText(path));
						List<SubMissionInfo> list = missionInfo2?.SubMissionList;
						if (list != null && list.Count > 0)
						{
							missionInfo.SubMissionList = missionInfo2.SubMissionList;
						}
					}
					catch (Exception e)
					{
						ResourceCache.IsComplete = false;
						Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", $"MissionInfo_{missionExcel.Key}.partial.json", I18NManager.Translate("Word.Error")), e);
					}
				}
				if (missionInfo != null)
				{
					GameData.MainMissionData[missionExcel.Key].SetMissionInfo(missionInfo);
					count++;
				}
				else
				{
					missingMissionInfos = true;
				}
			}
			catch (Exception e2)
			{
				ResourceCache.IsComplete = false;
				missingMissionInfos = true;
				Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", $"MissionInfo_{missionExcel.Key}.json", I18NManager.Translate("Word.Error")), e2);
			}
		});
		while (!parallelLoopResult.IsCompleted)
		{
			Thread.Sleep(10);
		}
		if (missingMissionInfos)
		{
			LogPartialMissingSummary(I18NManager.Translate("Word.MissionInfo"), missingCount, missingFiles);
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(), I18NManager.Translate("Word.MissionInfo")));
	}

	public static T? LoadCustomFile<T>(string filetype, string filename)
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", filetype));
		string text = Path.Combine(ConfigManager.Config.Path.ConfigPath, "Custom", filename + ".json");
		string text2 = Path.Combine(ConfigManager.Config.Path.ConfigPath, filename + ".json");
		FileInfo fileInfo = new FileInfo(File.Exists(text) ? text : text2);
		T val = default(T);
		if (!fileInfo.Exists)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", filetype, ConfigManager.Config.Path.ConfigPath + "/" + filename + ".json", filetype));
			return val;
		}
		try
		{
			using FileStream stream = fileInfo.OpenRead();
			using StreamReader streamReader = new StreamReader(stream);
			string text3 = streamReader.ReadToEnd();
			if (typeof(T) == typeof(BannersConfig))
			{
				JToken jToken = JToken.Parse(text3);
				if (jToken.Type == JTokenType.Array)
				{
					List<BannerConfig> banners = jToken.ToObject<List<BannerConfig>>() ?? new List<BannerConfig>();
					val = (T)(object)new BannersConfig
					{
						Banners = banners
					};
				}
				else
				{
					val = JsonConvert.DeserializeObject<T>(text3);
				}
			}
			else
			{
				val = JsonConvert.DeserializeObject<T>(text3);
			}
		}
		catch (Exception e)
		{
			ResourceCache.IsComplete = false;
			Logger.Error("Error in reading " + fileInfo.Name, e);
		}
		if (!(val is Dictionary<int, int> dictionary))
		{
			if (!(val is Dictionary<int, List<int>> dictionary2))
			{
				if (!(val is BannersConfig bannersConfig))
				{
					if (!(val is RogueMiracleEffectConfig rogueMiracleEffectConfig))
					{
						if (!(val is ActivityConfig activityConfig))
						{
							if (!(val is VideoKeysConfig videoKeysConfig))
							{
								if (val is SceneRainbowGroupPropertyConfig sceneRainbowGroupPropertyConfig)
								{
									Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", sceneRainbowGroupPropertyConfig.FloorProperty.Count.ToString(), filetype));
								}
								else
								{
									Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItem", filetype));
								}
							}
							else
							{
								Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", videoKeysConfig.TotalCount.ToString(), filetype));
							}
						}
						else
						{
							Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", activityConfig.ScheduleData.Count.ToString(), filetype));
						}
					}
					else
					{
						Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", rogueMiracleEffectConfig.Miracles.Count.ToString(), filetype));
					}
				}
				else
				{
					Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", bannersConfig.Banners.Count.ToString(), filetype));
				}
			}
			else
			{
				Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", dictionary2.Count.ToString(), filetype));
			}
		}
		else
		{
			Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", dictionary.Count.ToString(), filetype));
		}
		return val;
	}

	public static T? LoadDataFile<T>(string filetype, string filename)
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", filetype));
		string text = Path.Combine(ConfigManager.Config.Path.ConfigPath, "Data", filename + ".json");
		FileInfo fileInfo = new FileInfo(text);
		if (!fileInfo.Exists)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", filetype, text, filetype));
			return default(T);
		}
		try
		{
			using FileStream stream = fileInfo.OpenRead();
			using StreamReader streamReader = new StreamReader(stream);
			return JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
		}
		catch (Exception e)
		{
			ResourceCache.IsComplete = false;
			Logger.Error("Error in reading " + fileInfo.Name, e);
			return default(T);
		}
	}

	public static void ApplyChallengePeakOverrides()
	{
		foreach (ChallengePeakGroupOverride item in GameData.ChallengePeakOverrideConfig.ChallengePeak)
		{
			if (GameData.ChallengePeakGroupConfigData.TryGetValue(item.GroupId, out ChallengePeakGroupConfigExcel value))
			{
				ChallengePeakStageOverride challengePeakStageOverride = item.Stages.Values.FirstOrDefault();
				if (challengePeakStageOverride != null && challengePeakStageOverride.MapEntranceId > 0)
				{
					value.MapEntranceID = challengePeakStageOverride.MapEntranceId;
					value.MapEntranceBoss = challengePeakStageOverride.MapEntranceId;
				}
			}
			foreach (KeyValuePair<string, ChallengePeakStageOverride> stage in item.Stages)
			{
				if (int.TryParse(stage.Key, out var result) && GameData.ChallengePeakConfigData.TryGetValue(result, out ChallengePeakConfigExcel value2))
				{
					value2.OverrideMapEntranceId = stage.Value.MapEntranceId;
					value2.OverrideMazeGroupId = stage.Value.MazeGroupId;
					value2.OverrideNpcMonsterId = ((stage.Value.NpcMonsterId > 0) ? stage.Value.NpcMonsterId : item.NpcMonsterIdDefault);
					value2.RebuildChallengeMonsters();
				}
			}
		}
	}

	public static void LoadMazeSkill()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.MazeSkillInfo")));
		int count = 0;
		int missingCount = 0;
		List<string> missingFiles = new List<string>();
		object adventureAbilityLock = new object();
		ParallelLoopResult parallelLoopResult = Parallel.ForEach(GameData.AdventurePlayerData.Values, delegate(AdventurePlayerExcel adventure)
		{
			string text = adventure.PlayerJsonPath.Replace("_Config.json", "_Ability.json").Replace("ConfigCharacter", "ConfigAdventureAbility");
			string text2 = ConfigManager.Config.Path.ResourcePath + "/" + text;
			FileInfo fileInfo = new FileInfo(text2);
			if (!fileInfo.Exists)
			{
				Interlocked.Increment(ref missingCount);
				lock (missingFiles)
				{
					missingFiles.Add(text2);
					return;
				}
			}
			try
			{
				using FileStream stream = fileInfo.OpenRead();
				using StreamReader streamReader = new StreamReader(stream);
				AdventureAbilityConfigListInfo value = AdventureAbilityConfigListInfo.LoadFromJsonObject(JObject.Parse(streamReader.ReadToEnd().Replace("$type", "Type")));
				lock (adventureAbilityLock)
				{
					GameData.AdventureAbilityConfigListData.TryAdd(adventure.ID, value);
				}
				Interlocked.Increment(ref count);
			}
			catch (Exception e)
			{
				ResourceCache.IsComplete = false;
				Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", text, I18NManager.Translate("Word.Error")), e);
			}
		});
		ParallelLoopResult parallelLoopResult2 = Parallel.ForEach(GameData.NpcMonsterDataData.Values, delegate(NPCMonsterDataExcel adventure)
		{
			string text = adventure.ConfigEntityPath.Replace("_Entity.json", "_Ability.json").Replace("_Config.json", "_Ability.json").Replace("ConfigEntity", "ConfigAdventureAbility");
			string text2 = ConfigManager.Config.Path.ResourcePath + "/" + text;
			FileInfo fileInfo = new FileInfo(text2);
			if (!fileInfo.Exists)
			{
				Interlocked.Increment(ref missingCount);
				lock (missingFiles)
				{
					missingFiles.Add(text2);
					return;
				}
			}
			try
			{
				using FileStream stream = fileInfo.OpenRead();
				using StreamReader streamReader = new StreamReader(stream);
				AdventureAbilityConfigListInfo value = AdventureAbilityConfigListInfo.LoadFromJsonObject(JObject.Parse(streamReader.ReadToEnd().Replace("$type", "Type")));
				lock (adventureAbilityLock)
				{
					GameData.AdventureAbilityConfigListData.TryAdd(adventure.ID, value);
				}
				Interlocked.Increment(ref count);
			}
			catch (Exception e)
			{
				ResourceCache.IsComplete = false;
				Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", text, I18NManager.Translate("Word.Error")), e);
			}
		});
		while (!parallelLoopResult.IsCompleted || !parallelLoopResult2.IsCompleted)
		{
			Thread.Sleep(10);
		}
		if (missingCount > 0)
		{
			LogPartialMissingSummary(I18NManager.Translate("Word.MazeSkillInfo"), missingCount, missingFiles);
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(), I18NManager.Translate("Word.MazeSkillInfo")));
	}

	public static void LoadSummonUnit()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.SummonUnitInfo")));
		int count = 0;
		int missingCount = 0;
		List<string> missingFiles = new List<string>();
		ParallelLoopResult parallelLoopResult = Parallel.ForEach(GameData.SummonUnitDataData.Values, delegate(SummonUnitDataExcel summonUnit)
		{
			string text = ConfigManager.Config.Path.ResourcePath + "/" + summonUnit.JsonPath;
			FileInfo fileInfo = new FileInfo(text);
			if (!fileInfo.Exists)
			{
				Interlocked.Increment(ref missingCount);
				lock (missingFiles)
				{
					missingFiles.Add(text);
					return;
				}
			}
			try
			{
				using FileStream stream = fileInfo.OpenRead();
				using StreamReader streamReader = new StreamReader(stream);
				SummonUnitConfigInfo configInfo = SummonUnitConfigInfo.LoadFromJsonObject(JObject.Parse(streamReader.ReadToEnd().Replace("$type", "Type")));
				summonUnit.ConfigInfo = configInfo;
				count++;
			}
			catch (Exception e)
			{
				ResourceCache.IsComplete = false;
				Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", summonUnit.JsonPath, I18NManager.Translate("Word.Error")), e);
			}
		});
		while (!parallelLoopResult.IsCompleted)
		{
			Thread.Sleep(10);
		}
		if (missingCount > 0)
		{
			LogPartialMissingSummary(I18NManager.Translate("Word.SummonUnitInfo"), missingCount, missingFiles);
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(), I18NManager.Translate("Word.SummonUnitInfo")));
	}

	public static void LoadDialogueInfo()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.DialogueInfo")));
		int count = 0;
		int missingCount = 0;
		List<string> missingFiles = new List<string>();
		ParallelLoopResult parallelLoopResult = Parallel.ForEach(GameData.RogueNPCData.Values, delegate(RogueNPCExcel dialogue)
		{
			string text = ConfigManager.Config.Path.ResourcePath + "/" + dialogue.NPCJsonPath;
			FileInfo fileInfo = new FileInfo(text);
			if (!fileInfo.Exists)
			{
				Interlocked.Increment(ref missingCount);
				lock (missingFiles)
				{
					missingFiles.Add(text);
					return;
				}
			}
			try
			{
				using FileStream stream = fileInfo.OpenRead();
				using StreamReader streamReader = new StreamReader(stream);
				RogueNPCConfigInfo rogueNPCConfigInfo = JsonConvert.DeserializeObject<RogueNPCConfigInfo>(streamReader.ReadToEnd().Replace("$type", "Type"));
				if (rogueNPCConfigInfo != null)
				{
					dialogue.RogueNpcConfig = rogueNPCConfigInfo;
					count++;
					rogueNPCConfigInfo.Loaded();
				}
			}
			catch (Exception e)
			{
				ResourceCache.IsComplete = false;
				Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", fileInfo.Name, I18NManager.Translate("Word.Error")), e);
			}
		});
		while (!parallelLoopResult.IsCompleted)
		{
			Thread.Sleep(10);
		}
		if (missingCount > 0)
		{
			LogPartialMissingSummary(I18NManager.Translate("Word.DialogueInfo"), missingCount, missingFiles);
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(), I18NManager.Translate("Word.DialogueInfo")));
	}

	public static void LoadPerformanceInfo()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.PerformanceInfo")));
		int count = 0;
		ParallelLoopResult parallelLoopResult = Parallel.ForEach(GameData.PerformanceEData.Values, delegate(PerformanceEExcel performance)
		{
			if (performance.PerformancePath == "")
			{
				count++;
			}
			else
			{
				FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ResourcePath + "/" + performance.PerformancePath);
				if (fileInfo.Exists)
				{
					try
					{
						using FileStream stream = fileInfo.OpenRead();
						using StreamReader streamReader = new StreamReader(stream);
						LevelGraphConfigInfo actInfo = LevelGraphConfigInfo.LoadFromJsonObject(JObject.Parse(streamReader.ReadToEnd().Replace("$type", "Type")));
						performance.ActInfo = actInfo;
						count++;
					}
					catch (Exception e)
					{
						ResourceCache.IsComplete = false;
						Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", fileInfo.Name, I18NManager.Translate("Word.Error")), e);
					}
				}
			}
		});
		ParallelLoopResult parallelLoopResult2 = Parallel.ForEach(GameData.PerformanceDData.Values, delegate(PerformanceDExcel performance)
		{
			if (performance.PerformancePath == "")
			{
				count++;
			}
			else
			{
				FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ResourcePath + "/" + performance.PerformancePath);
				if (fileInfo.Exists)
				{
					try
					{
						using FileStream stream = fileInfo.OpenRead();
						using StreamReader streamReader = new StreamReader(stream);
						LevelGraphConfigInfo actInfo = LevelGraphConfigInfo.LoadFromJsonObject(JObject.Parse(streamReader.ReadToEnd().Replace("$type", "Type")));
						performance.ActInfo = actInfo;
						count++;
					}
					catch (Exception e)
					{
						ResourceCache.IsComplete = false;
						Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", fileInfo.Name, I18NManager.Translate("Word.Error")), e);
					}
				}
			}
		});
		while (!parallelLoopResult.IsCompleted || !parallelLoopResult2.IsCompleted)
		{
			Thread.Sleep(10);
		}
		_ = count;
		_ = GameData.PerformanceEData.Count + GameData.PerformanceDData.Count;
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(), I18NManager.Translate("Word.PerformanceInfo")));
	}

	public static void LoadSubMissionInfo()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.SubMissionInfo")));
		int count = 0;
		ParallelLoopResult parallelLoopResult = Parallel.ForEach(GameData.SubMissionInfoData.Values, delegate(SubMissionData subMission)
		{
			if (subMission.SubMissionInfo != null && !(subMission.SubMissionInfo.MissionJsonPath == ""))
			{
				FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ResourcePath + "/" + subMission.SubMissionInfo.MissionJsonPath);
				if (fileInfo.Exists)
				{
					try
					{
						using FileStream stream = fileInfo.OpenRead();
						using StreamReader streamReader = new StreamReader(stream);
						LevelGraphConfigInfo subMissionTaskInfo = LevelGraphConfigInfo.LoadFromJsonObject(JObject.Parse(streamReader.ReadToEnd().Replace("$type", "Type")));
						subMission.SubMissionTaskInfo = subMissionTaskInfo;
						count++;
					}
					catch (Exception e)
					{
						ResourceCache.IsComplete = false;
						Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", fileInfo.Name, I18NManager.Translate("Word.Error")), e);
					}
				}
			}
		});
		while (!parallelLoopResult.IsCompleted)
		{
			Thread.Sleep(10);
		}
		_ = count;
		_ = GameData.SubMissionInfoData.Count;
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(), I18NManager.Translate("Word.SubMissionInfo")));
	}

	public static void LoadRogueChestMapInfo()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.RogueChestMapInfo")));
		int num = 0;
		List<RogueDLCChessBoardExcel> list = new List<RogueDLCChessBoardExcel>();
		foreach (List<RogueDLCChessBoardExcel> value in GameData.RogueNousChessBoardData.Values)
		{
			list.AddRange(value);
		}
		foreach (List<RogueDLCChessBoardExcel> value2 in GameData.RogueSwarmChessBoardData.Values)
		{
			list.AddRange(value2);
		}
		foreach (RogueDLCChessBoardExcel item in list)
		{
			if (item.ChessBoardConfiguration == "")
			{
				num++;
				continue;
			}
			FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ResourcePath + "/" + item.ChessBoardConfiguration);
			if (!fileInfo.Exists)
			{
				continue;
			}
			try
			{
				using FileStream stream = fileInfo.OpenRead();
				using StreamReader streamReader = new StreamReader(stream);
				RogueChestMapInfo rogueChestMapInfo = JsonConvert.DeserializeObject<RogueChestMapInfo>(streamReader.ReadToEnd());
				if (rogueChestMapInfo != null)
				{
					item.MapInfo = rogueChestMapInfo;
					num++;
				}
			}
			catch (Exception e)
			{
				ResourceCache.IsComplete = false;
				Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", fileInfo.Name, I18NManager.Translate("Word.Error")), e);
			}
		}
		if (num < list.Count)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", I18NManager.Translate("Word.RogueChestMapInfo"), ConfigManager.Config.Path.ResourcePath + "/Config/Gameplays/RogueDLC", I18NManager.Translate("Word.RogueChestMap")));
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", num.ToString(), I18NManager.Translate("Word.RogueChestMapInfo")));
	}

	public static void LoadAdventureModifier()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.AdventureModifierInfo")));
		int num = 0;
		DirectoryInfo directoryInfo = new DirectoryInfo(ConfigManager.Config.Path.ResourcePath + "/Config/ConfigAdventureModifier");
		if (!directoryInfo.Exists)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", I18NManager.Translate("Word.AdventureModifierInfo"), ConfigManager.Config.Path.ResourcePath + "/Config/ConfigAdventureModifier", I18NManager.Translate("Word.Buff")));
			return;
		}
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			try
			{
				using FileStream stream = fileInfo.OpenRead();
				using StreamReader streamReader = new StreamReader(stream);
				foreach (KeyValuePair<string, AdventureModifierConfig> item in AdventureModifierLookupTableConfig.LoadFromJObject(JObject.Parse(streamReader.ReadToEnd().Replace("$type", "Type"))).ModifierMap)
				{
					GameData.AdventureModifierData.Add(item.Key, item.Value);
					num++;
				}
			}
			catch (Exception e)
			{
				ResourceCache.IsComplete = false;
				Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", fileInfo.Name, I18NManager.Translate("Word.Error")), e);
			}
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", num.ToString(), I18NManager.Translate("Word.AdventureModifierInfo")));
	}

	public static void LoadLocalPlayer()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.LocalPlayerCharacter")));
		int count = 0;
		ParallelLoopResult parallelLoopResult = Parallel.ForEach(GameData.AdventurePlayerData.Values, delegate(AdventurePlayerExcel excel)
		{
			FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ResourcePath + "/" + excel.PlayerJsonPath);
			if (!fileInfo.Exists)
			{
				return;
			}
			try
			{
				using FileStream stream = fileInfo.OpenRead();
				using StreamReader streamReader = new StreamReader(stream);
				CharacterConfigInfo characterConfigInfo = JsonConvert.DeserializeObject<CharacterConfigInfo>(streamReader.ReadToEnd().Replace("$type", "Type"));
				if (characterConfigInfo != null)
				{
					GameData.CharacterConfigInfoData.TryAdd(excel.ID, characterConfigInfo);
					count++;
				}
			}
			catch (Exception e)
			{
				ResourceCache.IsComplete = false;
				Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", excel.PlayerJsonPath, I18NManager.Translate("Word.Error")), e);
			}
		});
		while (!parallelLoopResult.IsCompleted)
		{
			Thread.Sleep(10);
		}
		if (count < GameData.SummonUnitDataData.Count)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", I18NManager.Translate("Word.LocalPlayerCharacterInfo"), ConfigManager.Config.Path.ResourcePath + "/Config/ConfigCharacter", I18NManager.Translate("Word.LocalPlayerCharacter")));
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", count.ToString(), I18NManager.Translate("Word.LocalPlayerCharacterInfo")));
	}

	public static void LoadChessRogueRoomData()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.ChessRogueRoomInfo")));
		int num = 0;
		FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ConfigPath + "/ChessRogueRoomGen.json");
		if (!fileInfo.Exists)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", I18NManager.Translate("Word.ChessRogueRoomInfo"), ConfigManager.Config.Path.ConfigPath + "/ChessRogueRoomGen.json", I18NManager.Translate("Word.ChessRogueRoom")));
			return;
		}
		try
		{
			using FileStream stream = fileInfo.OpenRead();
			using StreamReader streamReader = new StreamReader(stream);
			foreach (ChessRogueRoomConfig item in JsonConvert.DeserializeObject<List<ChessRogueRoomConfig>>(streamReader.ReadToEnd()))
			{
				switch (item.BlockType)
				{
				case RogueDLCBlockTypeEnum.MonsterNormal:
					AddRoomToGameData(RogueDLCBlockTypeEnum.MonsterNormal, item);
					AddRoomToGameData(RogueDLCBlockTypeEnum.MonsterSwarm, item);
					num += 2;
					break;
				case RogueDLCBlockTypeEnum.MonsterBoss:
					AddRoomToGameData(RogueDLCBlockTypeEnum.MonsterBoss, item);
					AddRoomToGameData(RogueDLCBlockTypeEnum.MonsterNousBoss, item);
					AddRoomToGameData(RogueDLCBlockTypeEnum.MonsterSwarmBoss, item);
					num += 3;
					break;
				case RogueDLCBlockTypeEnum.Event:
					AddRoomToGameData(RogueDLCBlockTypeEnum.Event, item);
					AddRoomToGameData(RogueDLCBlockTypeEnum.Reward, item);
					AddRoomToGameData(RogueDLCBlockTypeEnum.Adventure, item);
					AddRoomToGameData(RogueDLCBlockTypeEnum.NousSpecialEvent, item);
					AddRoomToGameData(RogueDLCBlockTypeEnum.SwarmEvent, item);
					AddRoomToGameData(RogueDLCBlockTypeEnum.NousEvent, item);
					num += 6;
					break;
				case RogueDLCBlockTypeEnum.Trade:
					AddRoomToGameData(RogueDLCBlockTypeEnum.Trade, item);
					AddRoomToGameData(RogueDLCBlockTypeEnum.BlackMarket, item);
					num += 2;
					break;
				default:
					AddRoomToGameData(item.BlockType, item);
					num++;
					break;
				}
			}
		}
		catch (Exception e)
		{
			ResourceCache.IsComplete = false;
			Logger.Error("Error in reading " + fileInfo.Name, e);
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", num.ToString(), I18NManager.Translate("Word.ChessRogueRoomInfo")));
	}

	public static void LoadRogueTournRoomData()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.RogueTournRoomInfo")));
		int num = 0;
		FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ConfigPath + "/TournRogueRoomGen.json");
		if (!fileInfo.Exists)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", I18NManager.Translate("Word.RogueTournRoomInfo"), ConfigManager.Config.Path.ConfigPath + "/TournRogueRoomGen.json", I18NManager.Translate("Word.RogueTournRoom")));
			return;
		}
		try
		{
			using FileStream stream = fileInfo.OpenRead();
			using StreamReader streamReader = new StreamReader(stream);
			List<RogueTournRoomConfig> list = JsonConvert.DeserializeObject<List<RogueTournRoomConfig>>(streamReader.ReadToEnd());
			if (list == null)
			{
				throw new Exception("Failed to deserialize TournRogueRoomGen.json");
			}
			foreach (RogueTournRoomConfig item in list.Clone())
			{
				if (item.RoomType == RogueTournRoomTypeEnum.Event)
				{
					list.Add(item.Clone(RogueTournRoomTypeEnum.Reward));
					list.Add(item.Clone(RogueTournRoomTypeEnum.Encounter));
				}
			}
			GameData.RogueTournRoomGenData = list;
			num = list.Count;
		}
		catch (Exception e)
		{
			ResourceCache.IsComplete = false;
			Logger.Error("Error in reading " + fileInfo.Name, e);
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", num.ToString(), I18NManager.Translate("Word.RogueTournRoomInfo")));
	}

	public static void LoadRogueMagicRoomData()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.RogueMagicRoomInfo")));
		int num = 0;
		FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ConfigPath + "/RogueMagicRoomGen.json");
		if (!fileInfo.Exists)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", I18NManager.Translate("Word.RogueMagicRoomInfo"), ConfigManager.Config.Path.ConfigPath + "/RogueMagicRoomGen.json", I18NManager.Translate("Word.RogueMagicRoom")));
			return;
		}
		try
		{
			using FileStream stream = fileInfo.OpenRead();
			using StreamReader streamReader = new StreamReader(stream);
			List<RogueMagicRoomConfig> list = JsonConvert.DeserializeObject<List<RogueMagicRoomConfig>>(streamReader.ReadToEnd());
			if (list == null)
			{
				throw new Exception("Failed to deserialize RogueMagicRoomGen.json");
			}
			foreach (RogueMagicRoomConfig item in list.Clone())
			{
				if (item.RoomType == RogueMagicRoomTypeEnum.Event)
				{
					list.Add(item.Clone(RogueMagicRoomTypeEnum.Reward));
					list.Add(item.Clone(RogueMagicRoomTypeEnum.Encounter));
				}
			}
			GameData.RogueMagicRoomGenData = list;
			num = list.Count;
		}
		catch (Exception e)
		{
			ResourceCache.IsComplete = false;
			Logger.Error("Error in reading " + fileInfo.Name, e);
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", num.ToString(), I18NManager.Translate("Word.RogueMagicRoomInfo")));
	}

	public static void LoadChessRogueDiceSurfaceEffectData()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.RogueDiceSurfaceInfo")));
		int num = 0;
		FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ConfigPath + "/ChessRogueDiceSurfaceEffect.json");
		if (!fileInfo.Exists)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", I18NManager.Translate("Word.RogueDiceSurfaceInfo"), ConfigManager.Config.Path.ConfigPath + "/ChessRogueDiceSurfaceEffect.json", I18NManager.Translate("Word.RogueDiceSurface")));
			return;
		}
		try
		{
			using FileStream stream = fileInfo.OpenRead();
			using StreamReader streamReader = new StreamReader(stream);
			Dictionary<int, ChessRogueDiceSurfaceEffectConfig>? obj = JsonConvert.DeserializeObject<Dictionary<int, ChessRogueDiceSurfaceEffectConfig>>(streamReader.ReadToEnd()) ?? throw new Exception("Failed to deserialize ChessRogueDiceSurfaceEffect.json");
			GameData.ChessRogueDiceSurfaceEffectData = obj;
			num = obj.Count;
		}
		catch (Exception e)
		{
			ResourceCache.IsComplete = false;
			Logger.Error("Error in reading " + fileInfo.Name, e);
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", num.ToString(), I18NManager.Translate("Word.RogueDiceSurfaceInfo")));
	}

	public static void LoadRogueDialogueEventData()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.DialogueInfo")));
		int num = 0;
		FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ConfigPath + "/Rogue/Dialogue/CosmosRogueEvent.json");
		FileInfo fileInfo2 = new FileInfo(ConfigManager.Config.Path.ConfigPath + "/Rogue/Dialogue/Tourn2RogueEvent.json");
		FileInfo key = new FileInfo(ConfigManager.Config.Path.ConfigPath + "/Rogue/Dialogue/SwarmRogueEvent.json");
		FileInfo key2 = new FileInfo(ConfigManager.Config.Path.ConfigPath + "/Rogue/Dialogue/NousRogueEvent.json");
		FileInfo key3 = new FileInfo(ConfigManager.Config.Path.ConfigPath + "/Rogue/Dialogue/MagicRogueEvent.json");
		if (!fileInfo.Exists || !fileInfo2.Exists)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", I18NManager.Translate("Word.DialogueInfo"), ConfigManager.Config.Path.ConfigPath + "/Rogue/Dialogue/", I18NManager.Translate("Word.Dialogue")));
			return;
		}
		foreach (KeyValuePair<FileInfo, Dictionary<uint, RogueDialogueEventConfig>> item in new Dictionary<FileInfo, Dictionary<uint, RogueDialogueEventConfig>>
		{
			{
				fileInfo,
				GameData.CosmosRogueDialogueEventConfig
			},
			{
				fileInfo2,
				GameData.TournRogueDialogueEventConfig
			},
			{
				key,
				GameData.SwarmRogueDialogueEventConfig
			},
			{
				key2,
				GameData.NousRogueDialogueEventConfig
			},
			{
				key3,
				GameData.MagicRogueDialogueEventConfig
			}
		})
		{
			try
			{
				using FileStream stream = item.Key.OpenRead();
				using StreamReader streamReader = new StreamReader(stream);
				List<RogueDialogueEventConfig> list = JsonConvert.DeserializeObject<List<RogueDialogueEventConfig>>(streamReader.ReadToEnd());
				if (list == null)
				{
					throw new Exception("Failed to deserialize " + item.Key.Name);
				}
				foreach (RogueDialogueEventConfig item2 in list)
				{
					item.Value.Add((item2.NpcId << 2) | item2.Progress, item2);
				}
				num += list.Count;
			}
			catch (Exception e)
			{
				ResourceCache.IsComplete = false;
				Logger.Error("Error in reading " + fileInfo.Name, e);
			}
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", num.ToString(), I18NManager.Translate("Word.DialogueInfo")));
	}

	public static void LoadGridFightBasicRewardsData()
	{
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.GridFightRewardsInfo")));
		int num = 0;
		FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ConfigPath + "/GridFight/GridFightBasicOrbRewards.json");
		if (!fileInfo.Exists)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.ConfigMissing", I18NManager.Translate("Word.GridFightRewardsInfo"), ConfigManager.Config.Path.ConfigPath + "/GridFight/GridFightBasicOrbRewards.json", I18NManager.Translate("Word.GridFightRewards")));
			return;
		}
		try
		{
			using FileStream stream = fileInfo.OpenRead();
			using StreamReader streamReader = new StreamReader(stream);
			foreach (KeyValuePair<uint, Dictionary<uint, List<GridFightBasicBonusPoolV2Excel>>> item in JsonConvert.DeserializeObject<Dictionary<uint, Dictionary<uint, List<GridFightBasicBonusPoolV2Excel>>>>(streamReader.ReadToEnd()) ?? throw new Exception("Failed to deserialize GridFightBasicOrbRewards.json"))
			{
				GameData.GridFightBasicOrbRewardsConfig.OrbRewards.Add(item.Key, new GridFightBasicOrbRewardsInfo
				{
					OrbId = item.Key,
					Rewards = item.Value
				});
				num++;
			}
		}
		catch (Exception e)
		{
			ResourceCache.IsComplete = false;
			Logger.Error("Error in reading " + fileInfo.Name, e);
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItems", num.ToString(), I18NManager.Translate("Word.GridFightRewardsInfo")));
	}

	public static void AddRoomToGameData(RogueDLCBlockTypeEnum type, ChessRogueRoomConfig room)
	{
		if (GameData.ChessRogueRoomData.TryGetValue(type, out List<ChessRogueRoomConfig> value))
		{
			value.Add(room);
			return;
		}
		Dictionary<RogueDLCBlockTypeEnum, List<ChessRogueRoomConfig>> chessRogueRoomData = GameData.ChessRogueRoomData;
		int num = 1;
		List<ChessRogueRoomConfig> list = new List<ChessRogueRoomConfig>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = room;
		chessRogueRoomData.Add(type, list);
	}
}
