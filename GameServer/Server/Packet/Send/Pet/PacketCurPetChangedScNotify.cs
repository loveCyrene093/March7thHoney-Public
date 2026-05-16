using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Pet;

public class PacketCurPetChangedScNotify : BasePacket
{
	public PacketCurPetChangedScNotify(uint newPetId)
		: base(7610)
	{
		CurPetChangedScNotify data = new CurPetChangedScNotify
		{
			CurPetId = newPetId
		};
		SetData(data);
	}
}
