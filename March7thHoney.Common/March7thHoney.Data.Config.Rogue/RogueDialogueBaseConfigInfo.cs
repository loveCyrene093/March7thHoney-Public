using System;
using System.IO;
using March7thHoney.Internationalization;
using March7thHoney.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Data.Config.Rogue;

public class RogueDialogueBaseConfigInfo
{
	public string OptionPath { get; set; } = string.Empty;

	public string DialoguePath { get; set; } = string.Empty;

	[JsonIgnore]
	public LevelGraphConfigInfo? DialogueInfo { get; set; }

	[JsonIgnore]
	public RogueDialogueEventConfigInfo? OptionInfo { get; set; }

	public void Loaded()
	{
		Logger byClassName = Logger.GetByClassName();
		if (!string.IsNullOrEmpty(OptionPath))
		{
			FileInfo fileInfo = new FileInfo(ConfigManager.Config.Path.ResourcePath + "/" + OptionPath);
			if (!fileInfo.Exists)
			{
				return;
			}
			try
			{
				using FileStream stream = fileInfo.OpenRead();
				using StreamReader streamReader = new StreamReader(stream);
				RogueDialogueEventConfigInfo optionInfo = JsonConvert.DeserializeObject<RogueDialogueEventConfigInfo>(streamReader.ReadToEnd());
				OptionInfo = optionInfo;
			}
			catch (Exception e)
			{
				byClassName.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", fileInfo.Name, I18NManager.Translate("Word.Error")), e);
			}
		}
		if (string.IsNullOrEmpty(DialoguePath))
		{
			return;
		}
		FileInfo fileInfo2 = new FileInfo(ConfigManager.Config.Path.ResourcePath + "/" + DialoguePath);
		if (!fileInfo2.Exists)
		{
			return;
		}
		try
		{
			using FileStream stream2 = fileInfo2.OpenRead();
			using StreamReader streamReader2 = new StreamReader(stream2);
			LevelGraphConfigInfo dialogueInfo = LevelGraphConfigInfo.LoadFromJsonObject(JObject.Parse(streamReader2.ReadToEnd().Replace("$type", "Type")));
			DialogueInfo = dialogueInfo;
		}
		catch (Exception e2)
		{
			byClassName.Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", fileInfo2.Name, I18NManager.Translate("Word.Error")), e2);
		}
	}
}
