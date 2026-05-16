using System.Collections.Generic;
using March7thHoney.Data.Config;
using March7thHoney.Database.Quests;
using March7thHoney.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("MainMission.json")]
public class MainMissionExcel : ExcelResource
{
	public int MainMissionID { get; set; }

	public HashName Name { get; set; } = new HashName();

	[JsonConverter(typeof(StringEnumConverter))]
	public OperationEnum TakeOperation { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public OperationEnum BeginOperation { get; set; }

	public List<MissionParam> TakeParam { get; set; } = new List<MissionParam>();

	public List<MissionParam> BeginParam { get; set; } = new List<MissionParam>();

	public int RewardID { get; set; }

	public List<int> SubRewardList { get; set; } = new List<int>();

	[JsonIgnore]
	public March7thHoney.Data.Config.MissionInfo MissionInfo { get; protected set; } = new March7thHoney.Data.Config.MissionInfo();

	[JsonIgnore]
	public List<int> SubMissionIds { get; set; } = new List<int>();

	public override int GetId()
	{
		return MainMissionID;
	}

	public override void Loaded()
	{
		GameData.MainMissionData[GetId()] = this;
	}

	public void SetMissionInfo(March7thHoney.Data.Config.MissionInfo missionInfo)
	{
		MissionInfo = missionInfo;
		if (missionInfo == null)
		{
			return;
		}
		foreach (SubMissionInfo subMission in missionInfo.SubMissionList)
		{
			SubMissionIds.Add(subMission.ID);
			GameData.SubMissionInfoData[subMission.ID] = new SubMissionData(subMission.ID)
			{
				MainMissionId = MainMissionID,
				MainMissionInfo = MissionInfo,
				SubMissionInfo = subMission
			};
		}
	}

	public bool IsEqual(MissionData data)
	{
		bool result = TakeOperation == OperationEnum.And;
		foreach (MissionParam item in TakeParam)
		{
			if (item.IsEqual(data))
			{
				if (TakeOperation != OperationEnum.And)
				{
					return true;
				}
			}
			else if (TakeOperation == OperationEnum.And)
			{
				return false;
			}
		}
		return result;
	}
}
