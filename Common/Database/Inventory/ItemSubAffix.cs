using March7thHoney.Data.Excel;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.Database.Inventory;

public class ItemSubAffix
{
	public int Id { get; set; }

	public int Count { get; set; }

	public int Step { get; set; }

	public ItemSubAffix()
	{
	}

	public ItemSubAffix(RelicSubAffixConfigExcel excel, int count)
	{
		Id = excel.AffixID;
		Count = count;
		Step = Extensions.RandomInt(0, excel.StepNum * count + 1);
	}

	public void IncreaseStep(int stepNum)
	{
		Count++;
		Step += Extensions.RandomInt(0, stepNum + 1);
	}

	public RelicAffix ToProto()
	{
		return new RelicAffix
		{
			AffixId = (uint)Id,
			Cnt = (uint)Count,
			Step = (uint)Step
		};
	}

	public ItemSubAffix Clone()
	{
		return new ItemSubAffix
		{
			Id = Id,
			Count = Count,
			Step = Step
		};
	}
}
