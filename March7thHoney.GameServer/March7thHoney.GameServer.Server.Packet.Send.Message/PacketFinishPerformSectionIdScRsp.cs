using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Message;

public class PacketFinishPerformSectionIdScRsp : BasePacket
{
	public PacketFinishPerformSectionIdScRsp(uint sectionId)
		: base(2726)
	{
		FinishPerformSectionIdScRsp data = new FinishPerformSectionIdScRsp
		{
			SectionId = sectionId
		};
		SetData(data);
	}
}
