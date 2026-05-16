using March7thHoney.Database.Account;

namespace March7thHoney.WebServer.Server;

public class MuipSession
{
	public string RsaPublicKey { get; set; } = "";

	public string SessionId { get; set; } = "";

	public long ExpireTimeStamp { get; set; }

	public bool IsAdmin { get; set; }

	public bool IsAuthorized { get; set; }

	public AccountData? Account { get; set; }
}
