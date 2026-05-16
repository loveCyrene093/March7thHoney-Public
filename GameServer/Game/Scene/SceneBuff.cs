using System.Collections.Generic;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Scene;

public class SceneBuff(int buffId, int buffLevel, int owner, int duration = -1)
{
	public Dictionary<string, float> DynamicValues { get; set; } = new Dictionary<string, float>();

	public int BuffId { get; } = buffId;

	public int BuffLevel { get; } = buffLevel;

	public int OwnerAvatarId { get; } = owner;

	public int Duration { get; set; } = duration;

	public long CreatedTime { get; set; } = Extensions.GetUnixMs();

	public int SummonUnitEntityId { get; set; }

	public int CastEntityId { get; set; }

	public SceneEntityBuffChangeType ChangeReason { get; set; } = SceneEntityBuffChangeType.AddMazebuff;

	public bool IsExpired()
	{
		if (Duration < 0)
		{
			return false;
		}
		return Extensions.GetUnixMs() - CreatedTime >= Duration * 1000;
	}

	public BuffInfo ToProto()
	{
		BuffInfo buffInfo = new BuffInfo
		{
			BuffId = (uint)BuffId,
			Level = (uint)BuffLevel,
			BaseAvatarId = (uint)OwnerAvatarId,
			AddTimeMs = (ulong)CreatedTime,
			LifeTime = Duration,
			BuffSummonEntityId = (uint)SummonUnitEntityId,
			Count = 1u
		};
		foreach (KeyValuePair<string, float> dynamicValue in DynamicValues)
		{
			buffInfo.DynamicValues.Add(dynamicValue.Key, dynamicValue.Value);
		}
		return buffInfo;
	}
}
