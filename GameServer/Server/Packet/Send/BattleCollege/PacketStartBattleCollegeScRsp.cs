using March7thHoney.GameServer.Game.Battle;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.BattleCollege;

public class PacketStartBattleCollegeScRsp : BasePacket
{
	public PacketStartBattleCollegeScRsp(uint id, Retcode retCode, BattleInstance? instance)
		: base(5714)
	{
		StartBattleCollegeScRsp startBattleCollegeScRsp = new StartBattleCollegeScRsp
		{
			Retcode = (uint)retCode,
			Id = id
		};
		if (instance != null)
		{
			startBattleCollegeScRsp.BattleInfo = instance.ToProto();
		}
		SetData(startBattleCollegeScRsp);
	}
}
