using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Archive;

public class PacketGetArchiveDataScRsp : BasePacket
{
	public PacketGetArchiveDataScRsp(PlayerInstance player)
		: base(2310)
	{
		GetArchiveDataScRsp getArchiveDataScRsp = new GetArchiveDataScRsp();
		ArchiveData info = new ArchiveData();
		GameData.MonsterConfigData.Values.ToList().ForEach(delegate(MonsterConfigExcel monster)
		{
			info.KillMonsterList.Add(new MonsterList
			{
				MonsterId = (uint)monster.GetId(),
				Num = 1u
			});
		});
		info.ArchiveAvatarIdList.Add(23027u);
		foreach (ItemData equipmentItem in player.InventoryManager.Data.EquipmentItems)
		{
			if (!info.ArchiveEquipmentIdList.Contains((uint)equipmentItem.ItemId))
			{
				info.ArchiveEquipmentIdList.Add((uint)equipmentItem.ItemId);
			}
		}
		foreach (ItemData relicItem in player.InventoryManager.Data.RelicItems)
		{
			GameData.RelicConfigData.TryGetValue(relicItem.ItemId, out RelicConfigExcel value);
			if (value != null)
			{
				info.RelicList.Add(new RelicList
				{
					SetId = (uint)value.SetID,
					Type = (uint)value.Type
				});
			}
		}
		getArchiveDataScRsp.ArchiveData = info;
		SetData(getArchiveDataScRsp);
	}
}
