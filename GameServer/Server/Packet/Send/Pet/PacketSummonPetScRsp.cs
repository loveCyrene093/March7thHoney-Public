using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Pet;

public class PacketSummonPetScRsp : BasePacket
{
	public PacketSummonPetScRsp(int curPetId, uint newPetId)
		: base(7614)
	{
		SummonPetScRsp data = new SummonPetScRsp
		{
			CurPetId = (uint)curPetId,
			SelectPetId = newPetId
		};
		SetData(data);
	}
}
