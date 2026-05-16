using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.ChessRogue;

[SugarTable("ChessRogueNous")]
public class ChessRogueNousData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public Dictionary<int, ChessRogueNousDiceData> RogueDiceData { get; set; } = new Dictionary<int, ChessRogueNousDiceData>();
}
