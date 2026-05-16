namespace March7thHoney.Data.Excel;

[ResourceEntity("CakeCatchConstValueCommon.json")]
public class CakeCatchConstValueCommonExcel : ExcelResource
{
	public string ConstValueName { get; set; } = "";

	public CakeCatchConstValue Value { get; set; } = new CakeCatchConstValue();

	public override int GetId()
	{
		return ConstValueName?.GetHashCode() ?? 0;
	}

	public override void Loaded()
	{
		if (!string.IsNullOrEmpty(ConstValueName))
		{
			GameData.CakeCatchConstValueData[ConstValueName] = this;
		}
	}
}
