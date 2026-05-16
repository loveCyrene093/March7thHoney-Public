using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Activity;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Server.Packet.Send.Activity;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Activity;

[Opcode(2629)]
public class HandlerTakeTrialActivityRewardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TakeTrialActivityRewardCsReq req = TakeTrialActivityRewardCsReq.Parser.ParseFrom(data);
		GameData.AvatarDemoConfigData.TryGetValue((int)req.StageId, out AvatarDemoConfigExcel value);
		if (value == null)
		{
			return;
		}
		GameData.RewardDataData.TryGetValue(value.RewardID, out RewardDataExcel value2);
		List<ItemData> itemList = new List<ItemData>();
		value2?.GetItems().ForEach(delegate((int, int) i)
		{
			ItemData result = connection.Player.InventoryManager.AddItem(i.Item1, i.Item2, notify: false).Result;
			if (result != null)
			{
				itemList.Add(result);
			}
		});
		List<TrialActivityResultData> activities = connection.Player.ActivityManager.Data.TrialActivityData.Activities;
		if (activities.Find((TrialActivityResultData x) => x.StageId == req.StageId) != null)
		{
			activities[activities.FindIndex((TrialActivityResultData x) => x.StageId == req.StageId)] = new TrialActivityResultData
			{
				StageId = (int)req.StageId,
				TakenReward = true
			};
		}
		connection.Player.Data.Hcoin += value2.Hcoin;
		await connection.Player.SendPacket(new PacketPlayerSyncScNotify(connection.Player.ToProto(), itemList));
		await connection.Player.SendPacket(new PacketScenePlaneEventScNotify(itemList));
		await connection.SendPacket(new PacketTakeTrialActivityRewardScRsp(req.StageId, itemList));
	}
}
