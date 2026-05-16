namespace March7thHoney.Internationalization.Message;

public class MissionTextEN
{
	public string Desc => "Manage player's missions.\nUse pass to complete all currently ongoing missions. This command can cause severe lag. Try to use /mission finish instead.\nUse finish [SubMissionID] to complete a specific sub mission. Please browse the handbook for SubMissionID.\nUse finishmain [MainMissionID] to complete a specific main mission. Please browse the handbook for MainMissionID.\nUse running <-all> to get tracked missions. Add '-all' to show all ongoing and potentially stuck missions. This may produce a long list, please review carefully.\nUse reaccept [MainMissionID] to restart a specific main mission. Please browse the handbook for MainMissionID.";

	public string Usage => "Usage: /mission pass\n\nUsage: /mission finish [SubMissionID]\n\nUsage: /mission running <-all>\n\nUsage: /mission reaccept [MainMissionID]\n\nUsage: /mission finishmain [MainMissionID]";

	public string AllMissionsFinished => "All missions finished!";

	public string AllRunningMissionsFinished => "Total {0} ongoing missions finished!";

	public string MissionFinished => "Mission {0} finished!";

	public string InvalidMissionId => "Invalid mission ID!";

	public string NoRunningMissions => "No ongoing missions!";

	public string RunningMissions => "Ongoing Missions:";

	public string PossibleStuckMissions => "Potentially Stuck Missions:";

	public string MainMission => "Main Mission";

	public string MissionReAccepted => "Re-accepted mission {0}!";
}
