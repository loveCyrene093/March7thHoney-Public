using System.Collections.Generic;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using SqlSugar;

namespace March7thHoney.Database.Scene;

[SugarTable("HeartDial")]
public class HeartDialData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public Dictionary<int, HeartDialInfo> DialList { get; set; } = new Dictionary<int, HeartDialInfo>();

	public HeartDialInfo ChangeScriptEmotion(int scriptId, HeartDialEmoTypeEnum emoType, HeartDialStepTypeEnum stepType)
	{
		if (DialList.TryGetValue(scriptId, out HeartDialInfo value))
		{
			value.EmoType = emoType;
			value.StepType = stepType;
			return value;
		}
		DialList.Add(scriptId, new HeartDialInfo
		{
			ScriptId = scriptId,
			EmoType = emoType,
			StepType = stepType
		});
		return DialList[scriptId];
	}

	public HeartDialInfo ChangeScriptEmotion(int scriptId, HeartDialEmoTypeEnum emoType)
	{
		if (DialList.TryGetValue(scriptId, out HeartDialInfo value))
		{
			value.EmoType = emoType;
			return value;
		}
		GameData.HeartDialScriptData.TryGetValue(scriptId, out HeartDialScriptExcel value2);
		DialList.Add(scriptId, new HeartDialInfo
		{
			ScriptId = scriptId,
			EmoType = emoType,
			StepType = (value2?.StepList[0] ?? HeartDialStepTypeEnum.Normal)
		});
		return DialList[scriptId];
	}
}
