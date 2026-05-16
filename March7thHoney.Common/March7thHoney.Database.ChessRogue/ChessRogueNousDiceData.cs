using System.Collections.Generic;
using March7thHoney.Proto;

namespace March7thHoney.Database.ChessRogue;

public class ChessRogueNousDiceData
{
	public int BranchId { get; set; }

	public Dictionary<int, int> Surfaces { get; set; } = new Dictionary<int, int>();

	public int AreaId { get; set; }

	public int DifficultyLevel { get; set; }

	public DFAOIALEBOH ToProto()
	{
		return new DFAOIALEBOH
		{
			FBMDOIAKCNB = (uint)BranchId
		};
	}
}
