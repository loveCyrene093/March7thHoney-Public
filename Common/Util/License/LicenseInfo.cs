namespace March7thHoney.Util.License;

public class LicenseInfo
{
	public const int TrialDays = 30;

	public string Hwid { get; set; } = "";

	public long ExpireAt { get; set; }

	public string Holder { get; set; } = "";
}
