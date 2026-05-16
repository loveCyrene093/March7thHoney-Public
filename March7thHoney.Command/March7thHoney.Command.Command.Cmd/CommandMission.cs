using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Mission;
using March7thHoney.Internationalization;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("mission", "Game.Command.Mission.Desc", "Game.Command.Mission.Usage", new string[] { "m" }, "", "")]
public class CommandMission : ICommand
{
	[CommandMethod("0 pass")]
	public async ValueTask PassRunningMission(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		MissionManager mission = arg.Target.Player.MissionManager;
		int count = mission.GetRunningSubMissionIdList().Count;
		foreach (int runningSubMissionId in mission.GetRunningSubMissionIdList())
		{
			await mission.FinishSubMission(runningSubMissionId);
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.Mission.AllRunningMissionsFinished", count.ToString()));
	}

	[CommandMethod("0 finish")]
	public async ValueTask FinishRunningMission(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count < 1)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		if (!int.TryParse(arg.BasicArgs[0], out var missionId))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Mission.InvalidMissionId"));
			return;
		}
		await arg.Target.Player.MissionManager.FinishSubMission(missionId);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Mission.MissionFinished", missionId.ToString()));
	}

	[CommandMethod("0 running")]
	public async ValueTask ListRunningMission(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		MissionManager mission = arg.Target.Player.MissionManager;
		List<SubMissionInfo> runningMissions = mission.GetRunningSubMissionList();
		if (runningMissions.Count == 0)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Mission.NoRunningMissions"));
			return;
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.Mission.RunningMissions"));
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		foreach (SubMissionInfo item in runningMissions)
		{
			if (!dictionary.TryGetValue(item.MainMissionID, out var value))
			{
				value = new List<int>();
				dictionary[item.MainMissionID] = value;
			}
			value.Add(item.ID);
		}
		if ((arg.BasicArgs.Count == 1 && arg.BasicArgs[0] == "-all") || mission.Data.TrackingMainMissionId == 0)
		{
			await ShowMissionList(mission, dictionary, arg);
		}
		else
		{
			Dictionary<int, List<int>> dictionary2 = new Dictionary<int, List<int>>();
			dictionary2[mission.Data.TrackingMainMissionId] = dictionary[mission.Data.TrackingMainMissionId];
			await ShowMissionList(mission, dictionary2, arg);
		}
		await Task.CompletedTask;
	}

	public async ValueTask ShowMissionList(MissionManager mission, Dictionary<int, List<int>> missionMap, CommandArg arg)
	{
		List<int> possibleStuckIds = new List<int>();
		List<int> morePossibleStuckIds = new List<int>();
		foreach (KeyValuePair<int, List<int>> list in missionMap)
		{
			await arg.SendMsg($"{I18NManager.Translate("Game.Command.Mission.MainMission")} {list.Key}：");
			StringBuilder stringBuilder = new StringBuilder();
			foreach (int item in list.Value)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder2);
				handler.AppendFormatted(item);
				handler.AppendLiteral("、");
				stringBuilder3.Append(ref handler);
				if (item.ToString().StartsWith("10"))
				{
					possibleStuckIds.Add(item);
					SubMissionInfo? subMissionInfo = mission.GetSubMissionInfo(item);
					if (subMissionInfo != null && subMissionInfo.FinishType == MissionFinishTypeEnum.PropState)
					{
						morePossibleStuckIds.Add(item);
					}
				}
			}
			stringBuilder.Remove(stringBuilder.Length - 1, 1);
			await arg.SendMsg(stringBuilder.ToString());
		}
		if (morePossibleStuckIds.Count > 0)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Mission.PossibleStuckMissions"));
			StringBuilder stringBuilder4 = new StringBuilder();
			foreach (int item2 in morePossibleStuckIds)
			{
				StringBuilder stringBuilder2 = stringBuilder4;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder2);
				handler.AppendFormatted(item2);
				handler.AppendLiteral("、");
				stringBuilder5.Append(ref handler);
			}
			stringBuilder4.Remove(stringBuilder4.Length - 1, 1);
			await arg.SendMsg(stringBuilder4.ToString());
		}
		else
		{
			if (possibleStuckIds.Count <= 0)
			{
				return;
			}
			await arg.SendMsg(I18NManager.Translate("Game.Command.Mission.PossibleStuckMissions"));
			StringBuilder stringBuilder6 = new StringBuilder();
			foreach (int item3 in possibleStuckIds)
			{
				StringBuilder stringBuilder2 = stringBuilder6;
				StringBuilder stringBuilder7 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder2);
				handler.AppendFormatted(item3);
				handler.AppendLiteral("、");
				stringBuilder7.Append(ref handler);
			}
			stringBuilder6.Remove(stringBuilder6.Length - 1, 1);
			await arg.SendMsg(stringBuilder6.ToString());
		}
	}

	[CommandMethod("0 reaccept")]
	public async ValueTask ReAcceptMission(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count < 1)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		if (!int.TryParse(arg.BasicArgs[0], out var missionId))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Mission.InvalidMissionId"));
			return;
		}
		await arg.Target.Player.MissionManager.ReAcceptMainMission(missionId);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Mission.MissionReAccepted", missionId.ToString()));
	}

	[CommandMethod("0 finishmain")]
	public async ValueTask FinishMainMission(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count < 1)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		if (!int.TryParse(arg.BasicArgs[0], out var missionId))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Mission.InvalidMissionId"));
			return;
		}
		await arg.Target.Player.MissionManager.FinishMainMission(missionId);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Mission.MissionFinished", missionId.ToString()));
	}
}
