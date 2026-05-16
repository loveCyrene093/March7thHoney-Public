namespace March7thHoney.Data.Config.Task;

public class CreateSummonUnit : TaskConfigInfo
{
	public int SummonUnitID { get; set; }

	public DynamicFloat Duration { get; set; } = new DynamicFloat();
}
