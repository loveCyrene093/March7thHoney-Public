using System;
using System.Collections.Generic;
using Google.Protobuf;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Activity.Activities.DiceCombat;

public class DiceCombatActivityInstance : BaseActivityInstance
{
	public GetSystemDataRsp Snapshot { get; }

	public Dictionary<uint, DiceCombatStageState> Stages { get; } = new Dictionary<uint, DiceCombatStageState>();

	public DiceCombatActivityInstance(ActivityManager manager)
		: base(manager)
	{
		Snapshot = DiceCombatConfig.BuildOfficialCompletedSnapshot();
		foreach (INACEGAAALJ item in Snapshot.FAMFCIPLGON)
		{
			Stages[item.FLEOCMEFANH] = new DiceCombatStageState
			{
				Completed = true,
				CompletedTime = item.UnlockTimestamp
			};
		}
	}

	public DiceCombatAvatar? FindAvatar(uint avatarId)
	{
		foreach (DiceCombatAvatar avatar in Snapshot.AvatarList)
		{
			if (avatar.DiceAvatarId == avatarId)
			{
				return avatar;
			}
		}
		return null;
	}

	public void RecordStageFinish(uint stageId, bool isWin)
	{
		if (isWin)
		{
			long num = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			if (!Stages.TryGetValue(stageId, out DiceCombatStageState value))
			{
				value = new DiceCombatStageState();
				Stages[stageId] = value;
				Snapshot.FAMFCIPLGON.Add(new INACEGAAALJ
				{
					FLEOCMEFANH = stageId,
					UnlockTimestamp = num
				});
			}
			value.Completed = true;
			value.CompletedTime = num;
		}
	}

	public byte[] BuildSystemDataPayload()
	{
		return Snapshot.ToByteArray();
	}
}
