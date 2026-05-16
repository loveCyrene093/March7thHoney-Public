namespace March7thHoney.Configuration;

public class ServerTimeOption
{
	public bool EnableFakeServerTime { get; set; } = true;

	public string FixedDate { get; set; } = "2026-05-12";
}
