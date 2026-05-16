using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketOpenChestScNotify : BasePacket
{
	public PacketOpenChestScNotify(int chestId)
		: base(1435)
	{
		OpenChestScNotify data = new OpenChestScNotify
		{
			ChestId = (uint)chestId
		};
		SetData(data);
	}
}
