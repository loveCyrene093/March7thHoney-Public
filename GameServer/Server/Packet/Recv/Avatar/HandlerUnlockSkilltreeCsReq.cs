using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Avatar;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(314)]
public class HandlerUnlockSkilltreeCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		UnlockSkillTreeCsReq req = UnlockSkillTreeCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		GameData.AvatarSkillTreeConfigData.TryGetValue((int)(req.PointId * 100 + req.Level), out AvatarSkillTreeConfigExcel value);
		if (value == null)
		{
			await connection.SendPacket(new PacketUnlockSkilltreeScRsp(Retcode.RetSkilltreeConfigNotExist));
			return;
		}
		FormalAvatarInfo avatar = player.AvatarManager.GetFormalAvatar(value.AvatarID);
		if (avatar == null)
		{
			await connection.SendPacket(new PacketUnlockSkilltreeScRsp(Retcode.RetAvatarNotExist));
			return;
		}
		foreach (ItemCost item in req.ItemList)
		{
			await connection.Player.InventoryManager.RemoveItem((int)item.PileItem.ItemId, (int)item.PileItem.ItemNum);
		}
		avatar.GetCurPathInfo().GetSkillTree()[(int)req.PointId] = (int)req.Level;
		await connection.SendPacket(new PacketPlayerSyncScNotify(avatar));
		player.MissionManager?.HandleFinishType(MissionFinishTypeEnum.UnlockSkilltreeCnt, "UnlockSkillTree");
		player.MissionManager?.HandleFinishType(MissionFinishTypeEnum.UnlockSkilltree, "UnlockSkillTree");
		player.MissionManager?.HandleFinishType(MissionFinishTypeEnum.AllAvatarUnlockSkilltreeCnt, "UnlockSkillTree");
		await connection.SendPacket(new PacketUnlockSkilltreeScRsp(req.PointId, req.Level));
	}
}
