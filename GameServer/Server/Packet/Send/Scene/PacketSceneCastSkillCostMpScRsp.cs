using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketSceneCastSkillCostMpScRsp : BasePacket
{
	public PacketSceneCastSkillCostMpScRsp(int entityId)
		: base(1404)
	{
		SceneCastSkillCostMpScRsp data = new SceneCastSkillCostMpScRsp
		{
			CastEntityId = (uint)entityId
		};
		SetData(data);
	}
}
