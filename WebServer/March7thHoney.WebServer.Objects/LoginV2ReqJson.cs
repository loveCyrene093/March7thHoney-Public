namespace March7thHoney.WebServer.Objects;

public class LoginV2ReqJson
{
	public int app_id { get; set; }

	public int channel_id { get; set; }

	public string? data { get; set; }

	public string? device { get; set; }

	public string? sign { get; set; }
}
