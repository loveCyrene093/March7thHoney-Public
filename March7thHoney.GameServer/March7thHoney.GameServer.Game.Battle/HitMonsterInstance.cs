using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Battle;

public class HitMonsterInstance
{
	public int MonsterId { get; set; }

	public MonsterBattleType BattleType { get; set; }

	public HitMonsterInstance(int monsterId, MonsterBattleType battleType)
	{
		MonsterId = monsterId;
		BattleType = battleType;
		base._002Ector();
	}

	public HitMonsterBattleInfo ToProto()
	{
		return new HitMonsterBattleInfo
		{
			MonsterBattleType = BattleType,
			TargetMonsterEntityId = (uint)MonsterId
		};
	}
}
