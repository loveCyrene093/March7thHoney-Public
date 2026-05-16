using System.Collections.Generic;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketSceneCastSkillScRsp : BasePacket
{
	public PacketSceneCastSkillScRsp(uint castEntityId, List<HitMonsterInstance> hitMonsters)
		: base(1418)
	{
		SceneCastSkillScRsp sceneCastSkillScRsp = new SceneCastSkillScRsp
		{
			CastEntityId = castEntityId
		};
		foreach (HitMonsterInstance hitMonster in hitMonsters)
		{
			sceneCastSkillScRsp.MonsterBattleInfo.Add(hitMonster.ToProto());
		}
		SetData(sceneCastSkillScRsp);
	}

	public PacketSceneCastSkillScRsp(uint castEntityId, BattleInstance battle, List<HitMonsterInstance> hitMonsters)
		: base(1418)
	{
		SceneCastSkillScRsp sceneCastSkillScRsp = new SceneCastSkillScRsp
		{
			CastEntityId = castEntityId,
			BattleInfo = battle.ToProto()
		};
		foreach (HitMonsterInstance hitMonster in hitMonsters)
		{
			sceneCastSkillScRsp.MonsterBattleInfo.Add(hitMonster.ToProto());
		}
		SetData(sceneCastSkillScRsp);
	}

	public PacketSceneCastSkillScRsp(Retcode retCode, uint castEntityId, BattleInstance? battle, List<HitMonsterInstance> hitMonsters)
		: base(1418)
	{
		SceneCastSkillScRsp sceneCastSkillScRsp = new SceneCastSkillScRsp
		{
			Retcode = (uint)retCode,
			CastEntityId = castEntityId
		};
		if (battle != null)
		{
			sceneCastSkillScRsp.BattleInfo = battle.ToProto();
		}
		foreach (HitMonsterInstance hitMonster in hitMonsters)
		{
			sceneCastSkillScRsp.MonsterBattleInfo.Add(hitMonster.ToProto());
		}
		SetData(sceneCastSkillScRsp);
	}
}
