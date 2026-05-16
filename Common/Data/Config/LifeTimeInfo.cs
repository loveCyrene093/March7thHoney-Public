namespace March7thHoney.Data.Config;

public class LifeTimeInfo
{
	public bool IsDynamic { get; set; }

	public FixedValueInfo<double> FixedValue { get; set; } = new FixedValueInfo<double>();

	public int GetLifeTime()
	{
		if (IsDynamic)
		{
			return 20;
		}
		if (FixedValue.Value <= 0.0 && FixedValue.Value >= -30000.0)
		{
			return -1;
		}
		if (FixedValue.Value < -30000.0)
		{
			return 20;
		}
		return (int)(FixedValue.Value * 10.0);
	}
}
