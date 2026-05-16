namespace March7thHoney.WebServer.Response;

public class CreateSessionData
{
	public string RsaPublicKey { get; set; } = "";

	public string SessionId { get; set; } = "";

	public long ExpireTimeStamp { get; set; }
}
