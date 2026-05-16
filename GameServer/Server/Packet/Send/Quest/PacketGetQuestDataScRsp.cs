using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Quest;

public class PacketGetQuestDataScRsp : BasePacket
{
	public PacketGetQuestDataScRsp(PlayerInstance player)
		: base(910)
	{
		GetQuestDataScRsp getQuestDataScRsp = new GetQuestDataScRsp();
		foreach (QuestDataExcel value in GameData.QuestDataData.Values)
		{
			getQuestDataScRsp.QuestList.Add(new March7thHoney.Proto.Quest
			{
				Id = (uint)value.QuestID,
				Status = (player.QuestManager?.GetQuestStatus(value.QuestID) ?? QuestStatus.QuestNone)
			});
		}
		SetData(getQuestDataScRsp);
	}
}
