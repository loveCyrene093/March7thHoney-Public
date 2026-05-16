using March7thHoney.Proto;

namespace March7thHoney.Database.Quests;

public class QuestInfo
{
	public int QuestId { get; set; }

	public QuestStatus QuestStatus { get; set; }

	public int Progress { get; set; }

	public long FinishTime { get; set; }

	public Quest ToProto()
	{
		return new Quest
		{
			Id = (uint)QuestId,
			Status = QuestStatus,
			Progress = (uint)Progress,
			FinishTime = FinishTime
		};
	}
}
