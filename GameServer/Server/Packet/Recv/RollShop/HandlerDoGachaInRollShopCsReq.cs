using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Server.Packet.Send.RollShop;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Recv.RollShop;

[Opcode(6902)]
public class HandlerDoGachaInRollShopCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DoGachaInRollShopCsReq req = DoGachaInRollShopCsReq.Parser.ParseFrom(data);
		ItemList itemList = new ItemList();
		uint count = req.GachaCount;
		uint maxtype = 3u;
		for (uint i = 0u; i < count; i++)
		{
			Dictionary<uint, uint> GroupIds = new Dictionary<uint, uint>();
			Dictionary<uint, uint> RewardIds = new Dictionary<uint, uint>();
			GameData.RollShopConfigData.Values.ToList().ForEach(delegate(RollShopConfigExcel x)
			{
				if (x.RollShopID == req.RollShopId)
				{
					GroupIds.Add(x.T1GroupID, 1u);
					GroupIds.Add(x.T2GroupID, 2u);
					GroupIds.Add(x.T3GroupID, 3u);
					GroupIds.Add(x.T4GroupID, 4u);
				}
			});
			GameData.RollShopRewardData.Values.ToList().ForEach(delegate(RollShopRewardExcel x)
			{
				GroupIds.Keys.ToList().ForEach(delegate(uint y)
				{
					if (x.GroupID == y)
					{
						RewardIds.Add(x.RewardID, GroupIds[y]);
					}
				});
			});
			uint key = RewardIds.Keys.ToList().RandomElement();
			uint num = RewardIds[key];
			if (num < maxtype)
			{
				maxtype = num;
			}
			List<(int, int)> items = GameData.RewardDataData[(int)key].GetItems();
			ItemData itemData = new ItemData
			{
				ItemId = items[0].Item1,
				Count = items[0].Item2
			};
			ItemData itemData2 = await connection.Player.InventoryManager.AddItem(itemData.ItemId, itemData.Count);
			if (itemData2 != null)
			{
				itemList.ItemList_.Add(itemData2.ToProto());
			}
			await connection.Player.InventoryManager.RemoveItem(122000, 1);
		}
		await connection.SendPacket(new PacketDoGachaInRollShopScRsp(req.RollShopId, itemList, maxtype));
	}
}
