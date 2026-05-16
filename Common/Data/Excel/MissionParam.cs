using March7thHoney.Database.Player;
using March7thHoney.Database.Quests;
using March7thHoney.Enums.Mission;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

public class MissionParam
{
	[JsonConverter(typeof(StringEnumConverter))]
	public MissionTakeTypeEnum Type { get; set; }

	public int Value { get; set; }

	public bool IsEqual(MissionData data)
	{
		return Type switch
		{
			MissionTakeTypeEnum.Auto => true, 
			MissionTakeTypeEnum.PlayerLevel => PlayerData.GetPlayerByUid(data.Uid).Level >= Value, 
			MissionTakeTypeEnum.WorldLevel => PlayerData.GetPlayerByUid(data.Uid).WorldLevel >= Value, 
			MissionTakeTypeEnum.MultiSequence => data.GetMainMissionStatus(Value) == MissionPhaseEnum.Finish, 
			_ => false, 
		};
	}
}
