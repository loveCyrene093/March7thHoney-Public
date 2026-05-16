namespace March7thHoney.WebServer.Objects;

public class LoginReqJson
{
	public string? account { get; set; }

	public string? password { get; set; }

	public bool is_crypto { get; set; }
}
