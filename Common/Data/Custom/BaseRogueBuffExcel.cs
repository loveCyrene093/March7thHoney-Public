using March7thHoney.Enums.Rogue;
using March7thHoney.Proto;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Custom;

public class BaseRogueBuffExcel : ExcelResource
{
	public int MazeBuffID { get; set; }

	public int MazeBuffLevel { get; set; }

	public int RogueBuffType { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueBuffCategoryEnum RogueBuffCategory { get; set; }

	public int RogueBuffTag { get; set; }

	public override int GetId()
	{
		return MazeBuffID * 100 + MazeBuffLevel;
	}

	public HJGFDIKDIHO ToProto()
	{
		return new HJGFDIKDIHO
		{
			BuffId = (uint)MazeBuffID,
			EBMHDHJKBKC = (uint)MazeBuffLevel
		};
	}
}
