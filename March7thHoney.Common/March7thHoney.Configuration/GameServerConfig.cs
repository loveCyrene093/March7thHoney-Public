namespace March7thHoney.Configuration;

public class GameServerConfig
{
	public string BindAddress { get; set; } = "0.0.0.0";

	public string PublicAddress { get; set; } = "127.0.0.1";

	public uint Port { get; set; } = 23301u;

	public string GameServerId { get; set; } = "March7th_Honey";

	public string GameServerName { get; set; } = "March7thHoney";

	public string GameServerDescription { get; set; } = "A re-implementation of StarRail server";

	public bool UsePacketEncryption { get; set; } = true;

	public string GetDisplayAddress()
	{
		return PublicAddress + ":" + Port;
	}
}
