using System.Collections.Generic;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Scene;

public class SceneBuff
{
	public Dictionary<string, float> DynamicValues { get; set; }

	public int BuffId { get; }

	public int BuffLevel { get; }

	public int OwnerAvatarId { get; }

	public int Duration { get; set; }

	public long CreatedTime { get; set; }

	public int SummonUnitEntityId { get; set; }

	public int CastEntityId { get; set; }

	public SceneEntityBuffChangeType ChangeReason { get; set; }

	public SceneBuff(int buffId, int buffLevel, int owner, int duration = -1)
	{
		DynamicValues = new Dictionary<string, float>();
		BuffId = buffId;
		BuffLevel = buffLevel;
		OwnerAvatarId = owner;
		Duration = duration;
		CreatedTime = Extensions.GetUnixMs();
		ChangeReason = SceneEntityBuffChangeType.AddMazebuff;
		base._002Ector();
	}

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
