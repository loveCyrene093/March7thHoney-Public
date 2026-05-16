using System.Collections.Generic;
using System.Text.Json.Serialization;
using March7thHoney.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.WebServer.Response;

public class PlayerInformationData
{
	public int Uid { get; set; }

	public string Name { get; set; } = "";

	public string Signature { get; set; } = "";

	public int HeadIconId { get; set; }

	public int Credit { get; set; }

	public int Jade { get; set; }

	public int CurPlaneId { get; set; }

	public int CurFloorId { get; set; }

	[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
	public PlayerStatusEnum PlayerStatus { get; set; } = PlayerStatusEnum.Explore;

	[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
	public PlayerSubStatusEnum PlayerSubStatus { get; set; }

	public int Stamina { get; set; }

	public int RecoveryStamina { get; set; }

	public List<int> AssistAvatarList { get; set; } = new List<int>();

	public List<int> DisplayAvatarList { get; set; } = new List<int>();

	public List<int> FinishedMainMissionIdList { get; set; } = new List<int>();

	public List<int> FinishedSubMissionIdList { get; set; } = new List<int>();

	public Dictionary<int, List<int>> AcceptedMissionList { get; set; } = new Dictionary<int, List<int>>();

	public List<int> LineupBaseAvatarIdList { get; set; } = new List<int>();
}
