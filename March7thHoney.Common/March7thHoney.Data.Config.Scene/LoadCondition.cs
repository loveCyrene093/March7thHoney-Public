using System;
using System.Collections.Generic;
using March7thHoney.Database.Quests;
using March7thHoney.Enums;
using March7thHoney.Enums.Mission;
using March7thHoney.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config.Scene;

public class LoadCondition
{
	public List<Condition> Conditions { get; set; } = new List<Condition>();

	[JsonConverter(typeof(StringEnumConverter))]
	public OperationEnum Operation { get; set; }

	public bool IsTrue(MissionData mission, bool defaultResult = true)
	{
		if (Conditions.Count == 0)
		{
			return defaultResult;
		}
		List<Func<bool>> list = new List<Func<bool>>();
		foreach (Condition condition2 in Conditions)
		{
			Condition condition = condition2;
			MissionPhaseEnum status;
			MissionPhaseEnum status2;
			if (condition.Type == LevelGroupMissionTypeEnum.MainMission)
			{
				status = mission.GetMainMissionStatus(condition.ID);
				if (!ConfigManager.Config.ServerOption.EnableMission)
				{
					status = MissionPhaseEnum.Finish;
				}
				condition.Phase = ((condition.Phase == MissionPhaseEnum.Cancel) ? MissionPhaseEnum.Finish : condition.Phase);
				list.Add(CheckFunc);
			}
			else
			{
				status2 = mission.GetSubMissionStatus(condition.ID);
				if (!ConfigManager.Config.ServerOption.EnableMission)
				{
					status2 = MissionPhaseEnum.Finish;
				}
				condition.Phase = ((condition.Phase == MissionPhaseEnum.Cancel) ? MissionPhaseEnum.Finish : condition.Phase);
				list.Add(CheckFunc2);
			}
			bool CheckFunc()
			{
				return status == condition.Phase;
			}
			bool CheckFunc2()
			{
				return status2 == condition.Phase;
			}
		}
		return Operation switch
		{
			OperationEnum.And => UtilTools.CheckAnd(list, defaultResult), 
			OperationEnum.Or => UtilTools.CheckOr(list, defaultResult), 
			OperationEnum.Not => !UtilTools.CheckOr(list, defaultResult), 
			_ => defaultResult, 
		};
	}
}
