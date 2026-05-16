using System.Collections.Generic;
using System.Linq;
using March7thHoney.Enums.Rogue;
using March7thHoney.Enums.TournRogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueTournFormula.json")]
public class RogueTournFormulaExcel : ExcelResource
{
	public string FormulaIcon { get; set; } = "";

	public string UltraFormulaIcon { get; set; } = "";

	public string FormulaSubIcon { get; set; } = "";

	public string FormulaStoryJson { get; set; } = "";

	public int MazeBuffID { get; set; }

	public int SubBuffNum { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueTournModeEnum TournMode { get; set; }

	public int UnlockDisplayID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueFormulaCategoryEnum FormulaCategory { get; set; }

	public bool IsInHandbook { get; set; }

	public int MainBuffTypeID { get; set; }

	public int FormulaDisplayID { get; set; }

	public int FormulaID { get; set; }

	public int MainBuffNum { get; set; }

	public int SubBuffTypeID { get; set; }

	public override int GetId()
	{
		return FormulaID;
	}

	public override void Loaded()
	{
		GameData.RogueTournFormulaData.TryAdd(GetId(), this);
	}

	public object ToProto(List<int> buffIdList)
	{
		return new
		{
			FormulaID = FormulaID,
			MainBuffTypeID = MainBuffTypeID,
			MainBuffNum = MainBuffNum,
			SubBuffTypeID = SubBuffTypeID,
			SubBuffNum = SubBuffNum,
			IsExpand = IsExpanded(buffIdList)
		};
	}

	public bool IsExpanded(List<int> buffIdList)
	{
		Dictionary<int, int> buffTypeNumDict = new Dictionary<int, int>();
		foreach (RogueTournBuffExcel item in from buff in buffIdList.Select((int buffId) => GameData.RogueBuffData.GetValueOrDefault(buffId * 100 + 1)).OfType<RogueTournBuffExcel>()
			where !buffTypeNumDict.TryAdd(buff.RogueBuffType, 1)
			select buff)
		{
			buffTypeNumDict[item.RogueBuffType]++;
		}
		if (buffTypeNumDict.GetValueOrDefault(MainBuffTypeID, 0) < MainBuffNum)
		{
			return false;
		}
		if (SubBuffTypeID != 0)
		{
			return buffTypeNumDict.GetValueOrDefault(SubBuffTypeID, 0) >= SubBuffNum;
		}
		return true;
	}

	public object ToResultProto(RogueCommonActionResultSourceType select, List<int> buffIdList)
	{
		return new
		{
			Source = (int)select,
			Data = ToProto(buffIdList)
		};
	}

	public object ToRemoveResultProto(RogueCommonActionResultSourceType select, List<int> buffIdList)
	{
		return new
		{
			Source = (int)select,
			Data = ToProto(buffIdList)
		};
	}

	public object ToExpandResultProto(RogueCommonActionResultSourceType select, List<int> buffIdList)
	{
		return new
		{
			Source = (int)select,
			Data = ToProto(buffIdList)
		};
	}

	public object ToContractResultProto(RogueCommonActionResultSourceType select, List<int> buffIdList)
	{
		return new
		{
			Source = (int)select,
			Data = ToProto(buffIdList)
		};
	}
}
