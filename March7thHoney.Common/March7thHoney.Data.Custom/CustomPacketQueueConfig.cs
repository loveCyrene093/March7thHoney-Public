using System.Collections.Generic;

namespace March7thHoney.Data.Custom;

public class CustomPacketQueueConfig
{
	public List<PacketActionData> Queue { get; set; } = new List<PacketActionData>();
}
