namespace March7thHoney.Configuration;

public class LogOption
{
	public bool EnableGamePacketLog { get; set; }

	public bool LogPacketToConsole { get; set; } = true;

	public bool DisableLogDetailPacket { get; set; }

	public bool SavePersonalDebugFile { get; set; }

	public bool LogResourceCacheLoading { get; set; } = true;
}
