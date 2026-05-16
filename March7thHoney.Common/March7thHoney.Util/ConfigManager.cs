using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using March7thHoney.Configuration;
using March7thHoney.Util.License;
using Newtonsoft.Json;

namespace March7thHoney.Util;

public static class ConfigManager
{
	public static readonly Logger Logger = new Logger("ConfigManager");

	private static readonly string ConfigFilePath = "Config.json";

	private static string HotfixFilePath => Config.Path.ConfigPath + "/Hotfix.json";

	public static bool IsPublicMode { get; private set; }

	public static ConfigContainer Config { get; private set; } = new ConfigContainer();

	public static HotfixContainer Hotfix { get; private set; } = new HotfixContainer();

	public static void LoadConfig(bool publicMode = false)
	{
		IsPublicMode = publicMode;
		if (IsPublicMode)
		{
			LoadPublicConfigData();
		}
		else
		{
			LoadConfigData();
		}
		LoadHotfixData();
	}

	private static void LoadConfigData()
	{
		FileInfo fileInfo = new FileInfo(ConfigFilePath);
		if (!fileInfo.Exists)
		{
			Config = new ConfigContainer
			{
				MuipServer = 
				{
					AdminKey = Guid.NewGuid().ToString()
				},
				ServerOption = 
				{
					Language = UtilTools.GetCurrentLanguage()
				}
			};
			Logger.Info("Current Language is " + Config.ServerOption.Language);
			Logger.Info("Muipserver Admin key: " + Config.MuipServer.AdminKey);
			SaveData(Config, ConfigFilePath);
		}
		using (FileStream stream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
		{
			using StreamReader streamReader = new StreamReader(stream);
			Config = JsonConvert.DeserializeObject<ConfigContainer>(streamReader.ReadToEnd(), new JsonSerializerSettings
			{
				ObjectCreationHandling = ObjectCreationHandling.Replace
			});
		}
		SaveData(Config, ConfigFilePath);
	}

	private static void LoadPublicConfigData()
	{
		Config = PublicConfigProvider.Create();
	}

	private static void LoadHotfixData()
	{
		FileInfo fileInfo = new FileInfo(HotfixFilePath);
		List<string> list = new List<string>();
		foreach (string item in new List<string> { "CN", "OS" })
		{
			if ("4.2.0"["4.2.0".Length - 1] == '5')
			{
				for (int i = 1; i < 6; i++)
				{
					list.Add(item + "4.2.0" + i);
				}
			}
			else
			{
				list.Add(item + "4.2.0");
			}
		}
		if (!fileInfo.Exists)
		{
			Hotfix = new HotfixContainer();
			SaveData(Hotfix, HotfixFilePath);
			fileInfo.Refresh();
		}
		using (FileStream stream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
		{
			using StreamReader streamReader = new StreamReader(stream);
			Hotfix = JsonConvert.DeserializeObject<HotfixContainer>(streamReader.ReadToEnd());
		}
		foreach (string item2 in list)
		{
			if (!Hotfix.HotfixData.TryGetValue(item2, out DownloadUrlConfig _))
			{
				Hotfix.HotfixData[item2] = new DownloadUrlConfig();
			}
		}
		SaveData(Hotfix, HotfixFilePath);
	}

	private static void SaveData(object data, string path)
	{
		string value = JsonConvert.SerializeObject(data, Formatting.Indented);
		using FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
		using StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.Write(value);
	}

	public static void InitDirectories()
	{
		PropertyInfo[] properties = Config.Path.GetType().GetProperties();
		for (int i = 0; i < properties.Length; i++)
		{
			string text = properties[i].GetValue(Config.Path)?.ToString();
			if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text) && !Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
		}
	}
}
