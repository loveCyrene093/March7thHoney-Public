using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Quests;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.GameServer.Server.Packet.Send.Quest;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Quest;

[Opcode(994)]
public class HandlerTakeQuestRewardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TakeQuestRewardCsReq takeQuestRewardCsReq = TakeQuestRewardCsReq.Parser.ParseFrom(data);
		List<ItemData> rewardItems = new List<ItemData>();
		Retcode ret = Retcode.RetSucc;
		List<int> succQuestIds = new List<int>();
		List<QuestInfo> refreshQuestList = new List<QuestInfo>();
		foreach (uint quest in takeQuestRewardCsReq.SuccQuestIdList)
		{
			var (retcode, list) = await connection.Player.QuestManager.TakeQuestReward((int)quest);
			if (retcode != Retcode.RetSucc)
			{
				ret = retcode;
				if (connection.Player.QuestManager.QuestData.Quests.TryGetValue((int)quest, out QuestInfo value))
				{
					refreshQuestList.Add(value);
				}
			}
			else
			{
				succQuestIds.Add((int)quest);
			}
			if (list != null)
			{
				rewardItems.AddRange(list);
			}
		}
		if (refreshQuestList.Count > 0)
		{
			await connection.SendPacket(new PacketPlayerSyncScNotify(refreshQuestList));
		}
		await connection.SendPacket(new PacketTakeQuestRewardScRsp(ret, rewardItems, succQuestIds));
	}
}
