using System.Collections.Generic;
using March7thHoney.Database.Lineup;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Battle;

public class MazeBuff(int buffID, int buffLevel, int owner)
{
	public int BuffID { get; } = buffID;

	public int BuffLevel { get; } = buffLevel;

	public int OwnerIndex { get; private set; } = owner;

	public int OwnerAvatarId { get; set; } = -1;

	public int? WaveFlag { get; set; }

	public int Duration { get; private set; } = -1;

	public Dictionary<string, float> DynamicValues { get; } = new Dictionary<string, float>();

	public MazeBuff(SceneBuff buff)
		: this(buff.BuffId, buff.BuffLevel, 0)
	{
		Duration = buff.Duration;
		OwnerAvatarId = buff.OwnerAvatarId;
		foreach (KeyValuePair<string, float> dynamicValue in buff.DynamicValues)
		{
			DynamicValues.Add(dynamicValue.Key, dynamicValue.Value);
		}
	}

	public BattleBuff ToProto(BattleInstance battle)
	{
		return ToProto(battle, WaveFlag ?? (-1));
	}

	public BattleBuff ToProto(BattleInstance instance, int waveFlag)
	{
		BattleBuff battleBuff = new BattleBuff
		{
			Id = (uint)BuffID,
			Level = (uint)BuffLevel,
			OwnerIndex = (uint)OwnerIndex,
			WaveFlag = (uint)waveFlag
		};
		foreach (KeyValuePair<string, float> dynamicValue in DynamicValues)
		{
			battleBuff.DynamicValues.Add(dynamicValue.Key, dynamicValue.Value);
		}
		if (OwnerAvatarId != -1)
		{
			battleBuff.OwnerIndex = (uint)instance.Lineup.BaseAvatars.FindIndex((LineupAvatarInfo x) => x.BaseAvatarId == OwnerAvatarId);
			OwnerIndex = (int)battleBuff.OwnerIndex;
		}
		if (OwnerIndex != -1)
		{
			battleBuff.TargetIndexList.Add((uint)OwnerIndex);
		}
		return battleBuff;
	}
}
