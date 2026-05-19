namespace March7thHoney.Configuration;

public class WatermarkConfig
{
	public bool Enabled { get; set; } = true;

	public string Line1Template { get; set; } = "{nickname}｜{serverName}";

	public string Line2Template { get; set; } = "{version}｜ {uid}";

	public double FontSize { get; set; } = 76.0;

	public bool UseGradient { get; set; } = true;

	public string GradientStartColor { get; set; } = "#54C3F7";

	public string GradientEndColor { get; set; } = "#C673AA";
}
