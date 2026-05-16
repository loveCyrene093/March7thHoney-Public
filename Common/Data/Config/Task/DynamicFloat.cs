namespace March7thHoney.Data.Config.Task;

public class DynamicFloat
{
	public bool IsDynamic { get; set; }

	public FixedValueInfo<int> FixedValue { get; set; } = new FixedValueInfo<int>();

	public int GetValue()
	{
		if (!IsDynamic)
		{
			return FixedValue.Value;
		}
		return 0;
	}
}
