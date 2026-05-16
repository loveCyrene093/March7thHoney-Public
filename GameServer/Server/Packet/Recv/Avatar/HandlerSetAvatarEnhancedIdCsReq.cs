using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.GameServer.Server.Packet.Send.Avatar;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(354)]
public class HandlerSetAvatarEnhancedIdCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetAvatarEnhancedIdCsReq setAvatarEnhancedIdCsReq = SetAvatarEnhancedIdCsReq.Parser.ParseFrom(data);
		int avatarId = (int)setAvatarEnhancedIdCsReq.AvatarId;
		int enhancedId = (int)setAvatarEnhancedIdCsReq.EnhancedId;
		FormalAvatarInfo avatar = connection.Player.AvatarManager.GetFormalAvatar(avatarId);
		if (avatar == null)
		{
			await connection.SendPacket(new PacketSetAvatarEnhancedIdScRsp(Retcode.RetAvatarNotExist));
			return;
		}
		PathInfo pathInfo = avatar.GetPathInfo(avatarId) ?? avatar.GetCurPathInfo();
		if (pathInfo == null)
		{
			await connection.SendPacket(new PacketSetAvatarEnhancedIdScRsp(Retcode.RetAvatarNotExist));
			return;
		}
		if (GameData.AvatarConfigData.TryGetValue(pathInfo.PathId, out AvatarConfigExcel value))
		{
			bool flag = value.SkillTree.ContainsKey(enhancedId) || value.DefaultSkillTree.ContainsKey(enhancedId);
			pathInfo.EnhanceId = (flag ? enhancedId : 0);
		}
		else
		{
			pathInfo.EnhanceId = enhancedId;
		}
		pathInfo.GetSkillTree();
		await connection.Player.SendPacket(new PacketSetAvatarEnhancedIdScRsp((uint)pathInfo.PathId, pathInfo.EnhanceId));
		await connection.Player.SendPacket(new PacketPlayerSyncScNotify(avatar));
	}
}
