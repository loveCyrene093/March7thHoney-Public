using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Proto;

namespace March7thHoney.Database.TrainParty;

public class TrainAreaInfo
{
	public int AreaId { get; set; }

	public List<int> StepList { get; set; } = new List<int>();

	public Dictionary<int, int> DynamicInfo { get; set; } = new Dictionary<int, int>();

	public TrainPartyArea ToProto()
	{
		TrainPartyArea trainPartyArea = new TrainPartyArea
		{
			AreaId = (uint)AreaId,
			AreaStepInfo = new AreaStepInfo(),
			StepIdList = { StepList.Select((int x) => (uint)x) },
			VerifyStepIdList = { StepList.Select((int x) => (uint)x) },
			Progress = 100u,
			DynamicInfo = { DynamicInfo.Select((KeyValuePair<int, int> x) => new AreaDynamicInfo
			{
				DiceSlotId = (uint)x.Key,
				DiyDynamicId = (uint)x.Value
			}) }
		};
		foreach (int step in StepList)
		{
			GameData.TrainPartyStepConfigData.TryGetValue(step, out TrainPartyStepConfigExcel value);
			if (value != null)
			{
				trainPartyArea.StaticPropIdList.AddRange(value.StaticPropIDList.Select((int x) => (uint)x));
			}
		}
		return trainPartyArea;
	}
}
