namespace March7thHoney.Internationalization.Message;

public class MissionTextCHS
{
	public string Desc => "管理玩家的任务\n使用 pass 完成当前正在进行的所有任务，此命令易造成严重卡顿，请尽量使用 /mission finish 替代\n使用 finish [子任务ID] 完成指定子任务，请浏览 handbook 来获取子任务ID\n使用 finishmain [主任务ID] 完成指定主任务，请浏览 handbook 来获取主任务ID\n使用 running <-all> 获取正在追踪的任务，增加'-all'则显示所有正在进行的任务以及可能卡住的任务，使用后可能会出现较长任务列表，请注意甄别\n使用 reaccept [主任务ID] 可重新进行指定主任务，请浏览 handbook 来获取主任务ID";

	public string Usage => "用法：/mission pass\n\n用法：/mission finish [子任务ID]\n\n用法：/mission running <-all>\n\n用法：/mission reaccept [主任务ID]\n\n用法：/mission finishmain [主任务ID]";

	public string AllMissionsFinished => "所有任务已完成!";

	public string AllRunningMissionsFinished => "共 {0} 个进行中的任务已完成!";

	public string MissionFinished => "任务 {0} 已完成!";

	public string InvalidMissionId => "无效的任务ID!";

	public string NoRunningMissions => "没有正在进行的任务!";

	public string RunningMissions => "正在进行的任务:";

	public string PossibleStuckMissions => "可能卡住的任务:";

	public string MainMission => "主任务";

	public string MissionReAccepted => "重新接受任务 {0}!";
}
