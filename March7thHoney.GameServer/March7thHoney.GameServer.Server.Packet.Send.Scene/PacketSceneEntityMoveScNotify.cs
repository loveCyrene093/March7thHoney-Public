using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketSceneEntityMoveScNotify : BasePacket
{
	public PacketSceneEntityMoveScNotify(PlayerInstance player)
		: base(1439)
	{
		SceneEntityMoveScNotify data = new SceneEntityMoveScNotify
		{
			EntryId = (uint)player.Data.EntryId,
			Motion = new MotionInfo
			{
				Pos = player.Data.Pos.ToProto(),
				Rot = player.Data.Rot.ToProto()
			}
		};
		SetData(data);
	}
}
