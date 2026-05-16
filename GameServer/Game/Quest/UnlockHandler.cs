using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.Enums.Mission;
using March7thHoney.Enums.Quest;
using March7thHoney.GameServer.Game.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Quest;

public class UnlockHandler(PlayerInstance player)
{
	public PlayerInstance Player { get; } = player;

	public bool GetUnlockStatus(int unlockId)
	{
		GameData.FuncUnlockDataData.TryGetValue(unlockId, out FuncUnlockDataExcel value);
		if (value == null)
		{
			return false;
		}
		foreach (FuncUnlockCondition condition in value.Conditions)
		{
			switch (condition.Type)
			{
			case ConditionTypeEnum.WorldLevel:
				if (Player.Data.WorldLevel < int.Parse(condition.Param))
				{
					return false;
				}
				break;
			case ConditionTypeEnum.FinishMainMission:
			{
				MissionManager? missionManager = Player.MissionManager;
				if (missionManager == null || missionManager.GetMainMissionStatus(int.Parse(condition.Param)) != MissionPhaseEnum.Finish)
				{
					return false;
				}
				break;
			}
			case ConditionTypeEnum.InStoryLine:
				if (Player.StoryLineManager?.StoryLineData.CurStoryLineId != int.Parse(condition.Param))
				{
					return false;
				}
				break;
			case ConditionTypeEnum.PlayerLevel:
				if (Player.Data.Level < int.Parse(condition.Param))
				{
					return false;
				}
				break;
			case ConditionTypeEnum.FinishSubMission:
			case ConditionTypeEnum.RealFinishSubMission:
			{
				MissionManager? missionManager2 = Player.MissionManager;
				if (missionManager2 == null || missionManager2.GetSubMissionStatus(int.Parse(condition.Param)) != MissionPhaseEnum.Finish)
				{
					return false;
				}
				break;
			}
			case ConditionTypeEnum.AvatarPathUnlock:
			{
				if (!int.TryParse(condition.Param, out var pathAvatarId))
				{
					return false;
				}
				bool flag = false;
				if (!((!GameData.MultiplePathAvatarConfigData.TryGetValue(pathAvatarId, out MultiplePathAvatarConfigExcel value2)) ? (Player.AvatarManager?.AvatarData.FormalAvatars.Any((FormalAvatarInfo x) => x.AvatarId == pathAvatarId || x.PathInfos.ContainsKey(pathAvatarId)) ?? false) : ((Player.AvatarManager?.GetFormalAvatar(value2.BaseAvatarID))?.PathInfos.ContainsKey(pathAvatarId) ?? false)))
				{
					return false;
				}
				break;
			}
			}
		}
		return true;
	}
}
