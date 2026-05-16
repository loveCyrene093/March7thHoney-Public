using System.Collections.Generic;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.Util;
using Newtonsoft.Json;

namespace March7thHoney.Data.Config;

public class SubMissionInfo
{
	public int ID { get; set; }

	public int LevelPlaneID { get; set; }

	public int LevelFloorID { get; set; }

	public int MainMissionID { get; set; }

	public string MissionJsonPath { get; set; } = "";

	[JsonConverter(typeof(SafeStringEnumConverter<SubMissionTakeTypeEnum>))]
	public SubMissionTakeTypeEnum TakeType { get; set; }

	public List<int>? TakeParamIntList { get; set; } = new List<int>();

	[JsonConverter(typeof(SafeStringEnumConverter<MissionFinishTypeEnum>))]
	public MissionFinishTypeEnum FinishType { get; set; }

	public int ParamInt1 { get; set; }

	public int ParamInt2 { get; set; }

	public int ParamInt3 { get; set; }

	public string ParamStr1 { get; set; } = "";

	public List<int>? ParamIntList { get; set; } = new List<int>();

	public List<MaterialItem>? ParamItemList { get; set; } = new List<MaterialItem>();

	public List<FinishActionInfo>? FinishActionList { get; set; } = new List<FinishActionInfo>();

	public int Progress { get; set; }

	public List<int>? GroupIDList { get; set; } = new List<int>();

	public int SubRewardID { get; set; }
}
