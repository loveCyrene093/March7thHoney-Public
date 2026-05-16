using March7thHoney.GameServer.Game.Battle;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketStartCocoonStageScRsp : BasePacket
{
	public PacketStartCocoonStageScRsp()
		: base(1454)
	{
		StartCocoonStageScRsp data = new StartCocoonStageScRsp
		{
			Retcode = 1u
		};
		SetData(data);
	}

	public PacketStartCocoonStageScRsp(BattleInstance battle, int cocoonId, int wave)
		: base(1454)
	{
		StartCocoonStageScRsp data = new StartCocoonStageScRsp
		{
			CocoonId = (uint)cocoonId,
			Wave = (uint)wave,
			BattleInfo = battle.ToProto()
		};
		SetData(data);
	}
}
