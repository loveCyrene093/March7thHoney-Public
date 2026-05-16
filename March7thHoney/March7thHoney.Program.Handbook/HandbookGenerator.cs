using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using March7thHoney.Command;
using March7thHoney.Configuration;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Internationalization;
using March7thHoney.Program.Program;
using March7thHoney.Util;
using Newtonsoft.Json;

namespace March7thHoney.Program.Handbook;

public static class HandbookGenerator
{
	private static string HandbookDir => Path.Combine(ConfigManager.Config.Path.ConfigPath, "Handbook");

	public static void GenerateAll()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(ConfigManager.Config.Path.ResourcePath + "/TextMap");
		DirectoryInfo directoryInfo2 = new DirectoryInfo(HandbookDir);
		if (!directoryInfo2.Exists)
		{
			directoryInfo2.Create();
		}
		if (!directoryInfo.Exists)
		{
			return;
		}
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			if (fileInfo.Extension != ".json")
			{
				return;
			}
			if (!fileInfo.Name.StartsWith("TextMapMain", StringComparison.OrdinalIgnoreCase))
			{
				string text = fileInfo.Name.Replace("TextMap", "").Replace(".json", "");
				string text2 = Path.Combine(HandbookDir, "Handbook " + text + ".txt");
				if (!File.Exists(text2) || !(new FileInfo(text2).LastWriteTime >= fileInfo.LastWriteTime))
				{
					Generate(text);
				}
			}
		}
		Logger.GetByClassName().Info(I18NManager.Translate("Server.ServerInfo.GeneratedItem", I18NManager.Translate("Word.Handbook")));
	}

	public static void Generate(string lang)
	{
		ConfigContainer config = ConfigManager.Config;
		string text = config.Path.ResourcePath + "/TextMap/TextMap" + lang + ".json";
		string path = config.Path.ResourcePath + "/TextMap/TextMap" + config.ServerOption.FallbackLanguage + ".json";
		if (!File.Exists(text))
		{
			Logger.GetByClassName().Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", text, I18NManager.Translate("Word.NotFound")));
			return;
		}
		if (!File.Exists(path))
		{
			Logger.GetByClassName().Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", text, I18NManager.Translate("Word.NotFound")));
			return;
		}
		Dictionary<BigInteger, string> dictionary = JsonConvert.DeserializeObject<Dictionary<BigInteger, string>>(File.ReadAllText(text));
		Dictionary<BigInteger, string> dictionary2 = JsonConvert.DeserializeObject<Dictionary<BigInteger, string>>(File.ReadAllText(path));
		if (dictionary == null || dictionary2 == null)
		{
			Logger.GetByClassName().Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", text, I18NManager.Translate("Word.Error")));
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("#Handbook generated in " + DateTime.Now.ToString("yyyy/MM/dd HH:mm"));
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("#Command");
		stringBuilder.AppendLine();
		GenerateCmd(stringBuilder, lang);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("#Avatar");
		stringBuilder.AppendLine();
		GenerateAvatar(stringBuilder, dictionary, dictionary2, lang == config.ServerOption.Language);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("#Item");
		stringBuilder.AppendLine();
		GenerateItem(stringBuilder, dictionary, dictionary2, lang == config.ServerOption.Language);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("#StageId");
		stringBuilder.AppendLine();
		GenerateStageId(stringBuilder, dictionary, dictionary2);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("#MainMission");
		stringBuilder.AppendLine();
		GenerateMainMissionId(stringBuilder, dictionary, dictionary2);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("#SubMission");
		stringBuilder.AppendLine();
		GenerateSubMissionId(stringBuilder, dictionary, dictionary2);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("#RogueBuff");
		stringBuilder.AppendLine();
		GenerateRogueBuff(stringBuilder, dictionary, dictionary2, lang == config.ServerOption.Language);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("#RogueMiracle");
		stringBuilder.AppendLine();
		GenerateRogueMiracleDisplay(stringBuilder, dictionary, dictionary2, lang == config.ServerOption.Language);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("#CurrencyWarRole");
		stringBuilder.AppendLine();
		GenerateCurrencyWarRole(stringBuilder, dictionary, dictionary2);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("#CurrencyWarEquipment");
		stringBuilder.AppendLine();
		GenerateCurrencyWarEquipment(stringBuilder, dictionary, dictionary2);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("#CurrencyWarConsumable");
		stringBuilder.AppendLine();
		GenerateCurrencyWarConsumable(stringBuilder, dictionary, dictionary2);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("#CurrencyWarOrb");
		stringBuilder.AppendLine();
		GenerateCurrencyWarOrb(stringBuilder, dictionary, dictionary2);
		stringBuilder.AppendLine();
		WriteToFile(lang, stringBuilder.ToString());
	}

	public static void GenerateCmd(StringBuilder builder, string lang)
	{
		foreach (KeyValuePair<string, CommandInfoAttribute> item in EntryPoint.CommandManager.CommandInfo)
		{
			builder.Append("\t" + item.Key);
			string text = I18NManager.TranslateAsCertainLang((lang == "CN") ? "CHS" : lang, item.Value.Description).Replace("\n", "\n\t\t");
			builder.AppendLine(": " + text);
		}
	}

	public static void GenerateItem(StringBuilder builder, Dictionary<BigInteger, string> map, Dictionary<BigInteger, string> fallback, bool setName)
	{
		foreach (ItemConfigExcel value2 in GameData.ItemConfigData.Values)
		{
			string value;
			string text = (map.TryGetValue(value2.ItemName.Hash, out value) ? value : (fallback.TryGetValue(value2.ItemName.Hash, out value) ? value : $"[{value2.ItemName.Hash}]"));
			builder.AppendLine(value2.ID + ": " + text);
			if (setName && text != $"[{value2.ItemName.Hash}]")
			{
				value2.Name = text;
			}
		}
	}

	public static void GenerateAvatar(StringBuilder builder, Dictionary<BigInteger, string> map, Dictionary<BigInteger, string> fallback, bool setName)
	{
		foreach (AvatarConfigExcel value2 in GameData.AvatarConfigData.Values)
		{
			string value;
			string text = (map.TryGetValue(value2.AvatarName.Hash, out value) ? value : (fallback.TryGetValue(value2.AvatarName.Hash, out value) ? value : $"[{value2.AvatarName.Hash}]"));
			builder.AppendLine(value2.AvatarID + ": " + text);
			if (setName && text != $"[{value2.AvatarName.Hash}]")
			{
				value2.Name = text;
			}
		}
	}

	public static void GenerateMainMissionId(StringBuilder builder, Dictionary<BigInteger, string> map, Dictionary<BigInteger, string> fallback)
	{
		foreach (MainMissionExcel value2 in GameData.MainMissionData.Values)
		{
			string value;
			string text = (map.TryGetValue(value2.Name.Hash, out value) ? value : (fallback.TryGetValue(value2.Name.Hash, out value) ? value : $"[{value2.Name.Hash}]"));
			builder.AppendLine(value2.MainMissionID + ": " + text);
		}
	}

	public static void GenerateSubMissionId(StringBuilder builder, Dictionary<BigInteger, string> map, Dictionary<BigInteger, string> fallback)
	{
		foreach (SubMissionExcel value2 in GameData.SubMissionData.Values)
		{
			string value;
			string text = (map.TryGetValue(value2.TargetText.Hash, out value) ? value : (fallback.TryGetValue(value2.TargetText.Hash, out value) ? value : $"[{value2.TargetText.Hash}]"));
			builder.AppendLine(value2.SubMissionID + ": " + text);
		}
	}

	public static void GenerateStageId(StringBuilder builder, Dictionary<BigInteger, string> map, Dictionary<BigInteger, string> fallback)
	{
		foreach (StageConfigExcel value2 in GameData.StageConfigData.Values)
		{
			string value;
			string text = (map.TryGetValue(value2.StageName.Hash, out value) ? value : (fallback.TryGetValue(value2.StageName.Hash, out value) ? value : $"[{value2.StageName.Hash}]"));
			builder.AppendLine(value2.StageID + ": " + text);
		}
	}

	public static void GenerateRogueBuff(StringBuilder builder, Dictionary<BigInteger, string> map, Dictionary<BigInteger, string> fallback, bool setName)
	{
		foreach (KeyValuePair<int, RogueMazeBuffExcel> rogueMazeBuffDatum in GameData.RogueMazeBuffData)
		{
			string value;
			string text = (map.TryGetValue(rogueMazeBuffDatum.Value.BuffName.Hash, out value) ? value : (fallback.TryGetValue(rogueMazeBuffDatum.Value.BuffName.Hash, out value) ? value : $"[{rogueMazeBuffDatum.Value.BuffName.Hash}]"));
			builder.AppendLine(rogueMazeBuffDatum.Key + ": " + text + " --- Level:" + rogueMazeBuffDatum.Value.Lv);
			if (setName && text != $"[{rogueMazeBuffDatum.Value.BuffName.Hash}]")
			{
				rogueMazeBuffDatum.Value.Name = text;
			}
		}
	}

	public static void GenerateRogueMiracleDisplay(StringBuilder builder, Dictionary<BigInteger, string> map, Dictionary<BigInteger, string> fallback, bool setName)
	{
		foreach (RogueMiracleExcel value2 in GameData.RogueMiracleData.Values)
		{
			string value;
			string text = (map.TryGetValue(value2.MiracleName.Hash, out value) ? value : (fallback.TryGetValue(value2.MiracleName.Hash, out value) ? value : $"[{value2.MiracleName.Hash}]"));
			builder.AppendLine(value2.MiracleID + ": " + text);
			if (setName && text != $"[{value2.MiracleName.Hash}]")
			{
				value2.Name = text;
			}
		}
	}

	public static void GenerateCurrencyWarRole(StringBuilder builder, Dictionary<BigInteger, string> map, Dictionary<BigInteger, string> fallback)
	{
		foreach (GridFightRoleBasicInfoExcel value2 in GameData.GridFightRoleBasicInfoData.Values)
		{
			if (GameData.AvatarConfigData.TryGetValue((int)value2.AvatarID, out AvatarConfigExcel value))
			{
				string nameFromTextMap = GetNameFromTextMap(value.AvatarName.Hash, map, fallback);
				builder.AppendLine(value2.ID + ": " + nameFromTextMap);
			}
		}
	}

	public static void GenerateCurrencyWarEquipment(StringBuilder builder, Dictionary<BigInteger, string> map, Dictionary<BigInteger, string> fallback)
	{
		foreach (GridFightEquipmentExcel value2 in GameData.GridFightEquipmentData.Values)
		{
			if (GameData.GridFightItemsData.TryGetValue(value2.ID, out GridFightItemsExcel value))
			{
				string nameFromTextMap = GetNameFromTextMap(value.ItemName.Hash, map, fallback);
				builder.AppendLine(value2.ID + ": " + nameFromTextMap);
			}
		}
	}

	public static void GenerateCurrencyWarConsumable(StringBuilder builder, Dictionary<BigInteger, string> map, Dictionary<BigInteger, string> fallback)
	{
		foreach (GridFightConsumablesExcel value2 in GameData.GridFightConsumablesData.Values)
		{
			if (GameData.GridFightItemsData.TryGetValue(value2.ID, out GridFightItemsExcel value))
			{
				string nameFromTextMap = GetNameFromTextMap(value.ItemName.Hash, map, fallback);
				builder.AppendLine(value2.ID + ": " + nameFromTextMap);
			}
		}
	}

	public static void GenerateCurrencyWarOrb(StringBuilder builder, Dictionary<BigInteger, string> map, Dictionary<BigInteger, string> fallback)
	{
		foreach (GridFightOrbExcel value in GameData.GridFightOrbData.Values)
		{
			string nameFromTextMap = GetNameFromTextMap(value.OrbName.Hash, map, fallback);
			builder.AppendLine(value.OrbID + ": " + nameFromTextMap);
		}
	}

	public static string GetNameFromTextMap(BigInteger key, Dictionary<BigInteger, string> map, Dictionary<BigInteger, string> fallback)
	{
		if (map.TryGetValue(key, out string value))
		{
			return value;
		}
		if (fallback.TryGetValue(key, out value))
		{
			return value;
		}
		return $"[{key}]";
	}

	public static void WriteToFile(string lang, string content)
	{
		File.WriteAllText(Path.Combine(HandbookDir, "Handbook " + lang + ".txt"), content);
	}
}
