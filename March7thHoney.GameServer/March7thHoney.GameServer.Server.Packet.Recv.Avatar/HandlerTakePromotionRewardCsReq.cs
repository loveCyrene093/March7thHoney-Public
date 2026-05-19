using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Database.Avatar;
using March7thHoney.GameServer.Server.Packet.Send.Avatar;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(361)]
public class HandlerTakePromotionRewardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TakePromotionRewardCsReq takePromotionRewardCsReq = TakePromotionRewardCsReq.Parser.ParseFrom(data);
		FormalAvatarInfo avatar = connection.Player.AvatarManager.GetFormalAvatar((int)takePromotionRewardCsReq.BaseAvatarId);
		if (avatar == null)
		{
			await connection.SendPacket(new PacketTakePromotionRewardScRsp(Retcode.RetAvatarNotExist));
			return;
		}
		int promotion = (int)takePromotionRewardCsReq.Promotion;
		if (promotion < 0 || promotion >= avatar.Promotion)
		{
			await connection.SendPacket(new PacketTakePromotionRewardScRsp(Retcode.RetPromotionRewardConfigNotExist));
			return;
		}
		if (avatar.HasTakenReward(promotion))
		{
			await connection.SendPacket(new PacketTakePromotionRewardScRsp(Retcode.RetPromotionRewardAlreadyTaken));
			return;
		}
		avatar.TakeReward((int)takePromotionRewardCsReq.Promotion);
		await connection.Player.InventoryManager.AddItem(101, 1, notify: false);
		await connection.SendPacket(new PacketPlayerSyncScNotify(avatar));
		await connection.SendPacket(new PacketTakePromotionRewardScRsp(Retcode.RetSucc, new List<March7thHoney.Proto.Item>(1)
		{
			new March7thHoney.Proto.Item
			{
				ItemId = 101u,
				Num = 1u
			}
		}));
	}
}
