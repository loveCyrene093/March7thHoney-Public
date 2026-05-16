using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketGetCurSceneInfoScRsp : BasePacket
{
	public PacketGetCurSceneInfoScRsp(PlayerInstance player)
		: base(1498)
	{
		GetCurSceneInfoScRsp data = new GetCurSceneInfoScRsp
		{
			Scene = player.SceneInstance.ToProto()
		};
		SetData(data);
	}
}
