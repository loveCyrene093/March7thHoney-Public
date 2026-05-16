using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Message;

public class PacketFinishSectionIdScRsp : BasePacket
{
	public PacketFinishSectionIdScRsp(uint sectionId)
		: base(2798)
	{
		FinishSectionIdScRsp data = new FinishSectionIdScRsp
		{
			SectionId = sectionId
		};
		SetData(data);
	}
}
