using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Scene;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.HeartDial;

public class PacketGetHeartDialInfoScRsp : BasePacket
{
	public PacketGetHeartDialInfoScRsp(PlayerInstance player)
		: base(6310)
	{
		GetHeartDialInfoScRsp getHeartDialInfoScRsp = new GetHeartDialInfoScRsp
		{
			UnlockStatus = HeartDialUnlockStatus.Lock
		};
		MissionManager? missionManager = player.MissionManager;
		if (missionManager != null && missionManager.GetSubMissionStatus(103040103) == MissionPhaseEnum.Finish)
		{
			getHeartDialInfoScRsp.UnlockStatus = HeartDialUnlockStatus.UnlockSingle;
		}
		MissionManager? missionManager2 = player.MissionManager;
		if (missionManager2 != null && missionManager2.GetSubMissionStatus(103040104) == MissionPhaseEnum.Finish)
		{
			getHeartDialInfoScRsp.UnlockStatus = HeartDialUnlockStatus.UnlockAll;
		}
		HeartDialData heartDialData = player.HeartDialData;
		foreach (HeartDialScriptExcel value2 in GameData.HeartDialScriptData.Values)
		{
			if (heartDialData.DialList.TryGetValue(value2.ScriptID, out HeartDialInfo value))
			{
				getHeartDialInfoScRsp.ScriptInfoList.Add(new HeartDialScriptInfo
				{
					ScriptId = (uint)value2.ScriptID,
					CurEmotionType = (HeartDialEmotionType)value.EmoType,
					Step = (HeartDialStepType)value.StepType
				});
			}
			else
			{
				getHeartDialInfoScRsp.ScriptInfoList.Add(new HeartDialScriptInfo
				{
					ScriptId = (uint)value2.ScriptID,
					CurEmotionType = (HeartDialEmotionType)value2.DefaultEmoType,
					Step = (HeartDialStepType)value2.StepList.First()
				});
			}
		}
		foreach (int key in GameData.HeartDialDialogueData.Keys)
		{
			getHeartDialInfoScRsp.DialogueInfoList.Add(new HeartDialDialogueInfo
			{
				DialogueId = (uint)key
			});
		}
		SetData(getHeartDialInfoScRsp);
	}
}
