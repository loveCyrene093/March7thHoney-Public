using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game.Mission.FinishAction.Handler;

[MissionFinishAction(FinishActionTypeEnum.ChangeLineup)]
public class MissionHandlerChangeLineup : MissionFinishActionHandler
{
	public override async ValueTask OnHandle(List<int> @params, List<string> paramString, PlayerInstance player)
	{
		player.LineupManager.GetCurLineup().BaseAvatars.Clear();
		int count = 0;
		int avatarCount = @params.Count((int num) => num != 0) - 1;
		foreach (int avatarId in @params)
		{
			if (count++ >= 4)
			{
				break;
			}
			GameData.SpecialAvatarData.TryGetValue(avatarId * 10 + player.Data.WorldLevel, out SpecialAvatarExcel value);
			if (value == null)
			{
				GameData.AvatarConfigData.TryGetValue(avatarId, out AvatarConfigExcel value2);
				if (value2 != null)
				{
					if (player.AvatarManager.GetFormalAvatar(avatarId) == null)
					{
						await player.AvatarManager.AddAvatar(avatarId);
					}
					await player.LineupManager.AddAvatarToCurTeam(avatarId, count == avatarCount);
				}
			}
			else
			{
				await player.LineupManager.AddSpecialAvatarToCurTeam(avatarId * 10 + player.Data.WorldLevel, count == avatarCount);
			}
		}
		GameData.SpecialAvatarData.TryGetValue(@params[4] * 10 + player.Data.WorldLevel, out SpecialAvatarExcel value3);
		if (value3 == null)
		{
			player.LineupManager.GetCurLineup().LeaderAvatarId = @params[4];
		}
		else
		{
			player.LineupManager.GetCurLineup().LeaderAvatarId = value3.AvatarID;
		}
		await player.SceneInstance.SyncLineup();
	}
}
