using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Challenge;

public class PacketEnterChallengeNextPhaseScRsp : BasePacket
{
	public PacketEnterChallengeNextPhaseScRsp(PlayerInstance instance)
		: base(1789)
	{
		EnterChallengeNextPhaseScRsp data = new EnterChallengeNextPhaseScRsp
		{
			Scene = instance.SceneInstance.ToProto()
		};
		SetData(data);
	}

	public PacketEnterChallengeNextPhaseScRsp(Retcode code)
		: base(1789)
	{
		EnterChallengeNextPhaseScRsp data = new EnterChallengeNextPhaseScRsp
		{
			Retcode = (uint)code
		};
		SetData(data);
	}
}
