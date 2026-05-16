namespace March7thHoney.Internationalization.Message;

public class MissionTextCHT
{
	public string Desc => "管理玩家的任務\n使用 pass 完成當前正在進行的所有任務，此命令易造成嚴重卡頓，請儘量使用 /mission finish 替代\n使用 finish [子任務ID] 完成指定子任務，請瀏覽 handbook 來獲取子任務ID\n使用 finishmain [主任務ID] 完成指定主任務，請瀏覽 handbook 來獲取主任務ID\n使用 running <-all> 獲取正在追蹤的任務，增加'-all'則顯示所有正在進行的任務以及可能卡住的任務，使用後可能會出現較長任務列表，請注意甄別\n使用 reaccept [主任務ID] 可重新進行指定主任務，請瀏覽 handbook 來獲取主任務ID";

	public string Usage => "用法：/mission pass\n\n用法：/mission finish [子任務ID]\n\n用法：/mission running <-all>\n\n用法：/mission reaccept [主任務ID]\n\n用法：/mission finishmain [主任務ID]";

	public string AllMissionsFinished => "所有任務已完成!";

	public string AllRunningMissionsFinished => "共 {0} 個進行中的任務已完成!";

	public string MissionFinished => "任務 {0} 已完成!";

	public string InvalidMissionId => "無效的任務ID!";

	public string NoRunningMissions => "沒有正在進行的任務!";

	public string RunningMissions => "正在進行的任務:";

	public string PossibleStuckMissions => "可能卡住的任務:";

	public string MainMission => "主任務";

	public string MissionReAccepted => "重新接受任務 {0}!";
}
