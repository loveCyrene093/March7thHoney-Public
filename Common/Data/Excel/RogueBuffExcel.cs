using System.Collections.Generic;
using System.Runtime.InteropServices;
using March7thHoney.Data.Custom;
using March7thHoney.Enums.Rogue;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Excel;

[ResourceEntity("RogueBuff.json")]
public class RogueBuffExcel : BaseRogueBuffExcel
{
	public int AeonID { get; set; }

	[JsonConverter(typeof(StringEnumConverter))]
	public RogueBuffAeonTypeEnum BattleEventBuffType { get; set; }

	public bool IsAeonBuff => BattleEventBuffType != RogueBuffAeonTypeEnum.Normal;

	public override void Loaded()
	{
		GameData.RogueBuffData.Add(GetId(), this);
		if (BattleEventBuffType == RogueBuffAeonTypeEnum.BattleEventBuff)
		{
			GameData.RogueAeonBuffData.Add(AeonID, this);
		}
		else if (BattleEventBuffType == RogueBuffAeonTypeEnum.BattleEventBuffEnhance)
		{
			if (GameData.RogueAeonEnhanceData.TryGetValue(AeonID, out List<RogueBuffExcel> value))
			{
				value.Add(this);
				return;
			}
			Dictionary<int, List<RogueBuffExcel>> rogueAeonEnhanceData = GameData.RogueAeonEnhanceData;
			int aeonID = AeonID;
			int num = 1;
			List<RogueBuffExcel> list = new List<RogueBuffExcel>(num);
			CollectionsMarshal.SetCount(list, num);
			CollectionsMarshal.AsSpan(list)[0] = this;
			rogueAeonEnhanceData.Add(aeonID, list);
		}
	}
}
