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
		if (avatar != null)
		{
			avatar.TakeReward((int)takePromotionRewardCsReq.Promotion);
			await connection.Player.InventoryManager.AddItem(101, 1, notify: false);
			await connection.SendPacket(new PacketPlayerSyncScNotify(avatar));
			await connection.SendPacket(new PacketTakePromotionRewardScRsp());
		}
	}
}
