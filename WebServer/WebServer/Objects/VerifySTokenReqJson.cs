namespace March7thHoney.WebServer.Objects;

public class VerifySTokenReqJson
{
	public class TokenInfo
	{
		public int token_type { get; set; }

		public string token { get; set; } = "";
	}

	public string mid { get; set; } = "";

	public bool refresh { get; set; }

	public TokenInfo token { get; set; } = new TokenInfo();
}
