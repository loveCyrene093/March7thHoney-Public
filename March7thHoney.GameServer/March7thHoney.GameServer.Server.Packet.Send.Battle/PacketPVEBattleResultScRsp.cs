using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Battle;

public class PacketPVEBattleResultScRsp : BasePacket
{
	public PacketPVEBattleResultScRsp()
		: base(110)
	{
		PVEBattleResultScRsp data = new PVEBattleResultScRsp
		{
			Retcode = 1u
		};
		SetData(data);
	}

	public PacketPVEBattleResultScRsp(PVEBattleResultCsReq req, PlayerInstance player, BattleInstance battle)
		: base(110)
	{
		PVEBattleResultScRsp data = new PVEBattleResultScRsp
		{
			DropData = battle.GetDropItemList(),
			StageId = req.StageId,
			BattleId = req.BattleId,
			EndStatus = req.EndStatus,
			CheckIdentical = true,
			ItemListUnk1 = new ItemList(),
			ItemListUnk2 = new ItemList(),
			MultipleDropData = new ItemList(),
			EventId = (uint)battle.EventId
		};
		SetData(data);
	}
}
