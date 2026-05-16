using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketSceneEntityTeleportScRsp : BasePacket
{
	public PacketSceneEntityTeleportScRsp(EntityMotion motion)
		: base(1441)
	{
		SceneEntityTeleportScRsp data = new SceneEntityTeleportScRsp
		{
			EntityMotion = motion
		};
		SetData(data);
	}
}
