using System.Collections.Generic;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueDLCArea.json")]
public class RogueDLCAreaExcel : ExcelResource
{
	public int AreaID { get; set; }

	public string SubType { get; set; } = "";

	public List<int> LayerIDList { get; set; } = new List<int>();

	public List<int> DifficultyID { get; set; } = new List<int>();

	public int FirstReward { get; set; }

	public List<RogueDLCAreaScoreMap> AreaScoreMap { get; set; } = new List<RogueDLCAreaScoreMap>();

	[JsonIgnore]
	public RogueSubModeEnum RogueVersionId { get; set; }

	public override int GetId()
	{
		return AreaID;
	}

	public override void Loaded()
	{
		GameData.RogueDLCAreaData[AreaID] = this;
		RogueVersionId = (SubType.Contains("Nous") ? RogueSubModeEnum.ChessRogueNous : RogueSubModeEnum.ChessRogue);
	}
}
