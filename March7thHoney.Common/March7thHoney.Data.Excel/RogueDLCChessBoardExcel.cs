using System.Collections.Generic;
using March7thHoney.Data.Config;
using Newtonsoft.Json;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueDLCChessBoard.json")]
public class RogueDLCChessBoardExcel : ExcelResource
{
	public int ChessBoardID { get; set; }

	public string ChessBoardConfiguration { get; set; } = string.Empty;

	[JsonIgnore]
	public RogueChestMapInfo? MapInfo { get; set; }

	public override int GetId()
	{
		return ChessBoardID;
	}

	public override void Loaded()
	{
		if (ChessBoardID.ToString().StartsWith("201"))
		{
			int key = int.Parse(ChessBoardID.ToString().Substring(3, 1));
			if (!GameData.RogueSwarmChessBoardData.TryGetValue(key, out List<RogueDLCChessBoardExcel> value))
			{
				value = new List<RogueDLCChessBoardExcel>();
				GameData.RogueSwarmChessBoardData[key] = value;
			}
			value.Add(this);
		}
		else if (ChessBoardID.ToString().StartsWith("211"))
		{
			int key2 = int.Parse(ChessBoardID.ToString().Substring(3, 1));
			if (!GameData.RogueNousChessBoardData.TryGetValue(key2, out List<RogueDLCChessBoardExcel> value2))
			{
				value2 = new List<RogueDLCChessBoardExcel>();
				GameData.RogueNousChessBoardData[key2] = value2;
			}
			value2.Add(this);
		}
	}
}
