using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;

namespace March7thHoney.GameServer.Server.Packet.Send.TrainCakeCatch;

public class PacketTrainCakeCatchGetDataScRsp : BasePacket
{
	public PacketTrainCakeCatchGetDataScRsp(PlayerInstance player)
		: base(9762)
	{
		SetData(player.TrainCakeCatchManager.ToGetDataProto());
	}
}
