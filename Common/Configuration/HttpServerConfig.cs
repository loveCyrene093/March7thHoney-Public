namespace March7thHoney.Configuration;

public class HttpServerConfig
{
	public string BindAddress { get; set; } = "0.0.0.0";

	public string PublicAddress { get; set; } = "127.0.0.1";

	public int Port { get; set; } = 21000;

	public bool UseSSL { get; set; }

	public bool SendHotfix { get; set; } = true;

	public bool UseFetchRemoteHotfix { get; set; }

	public string GetDisplayAddress()
	{
		return (UseSSL ? "https" : "http") + "://" + PublicAddress + ":" + Port;
	}

	public string GetBindDisplayAddress()
	{
		return (UseSSL ? "https" : "http") + "://" + BindAddress + ":" + Port;
	}
}
