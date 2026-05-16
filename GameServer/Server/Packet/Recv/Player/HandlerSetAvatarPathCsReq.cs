using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Avatar;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(366)]
public class HandlerSetAvatarPathCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetAvatarPathCsReq setAvatarPathCsReq = SetAvatarPathCsReq.Parser.ParseFrom(data);
		GameData.MultiplePathAvatarConfigData.TryGetValue((int)setAvatarPathCsReq.AvatarId, out MultiplePathAvatarConfigExcel avatar);
		if (avatar != null)
		{
			if (avatar.BaseAvatarID != 8001)
			{
				await connection.Player.ChangeAvatarPathType(avatar.BaseAvatarID, (MultiPathAvatarTypeEnum)avatar.AvatarID);
			}
			else
			{
				await connection.Player.ChangeAvatarPathType(avatar.BaseAvatarID, (MultiPathAvatarTypeEnum)(avatar.AvatarID - (connection.Player.Data.CurrentGender - 1)));
			}
			await connection.SendPacket(new PacketSetAvatarPathScRsp(avatar.AvatarID));
		}
		else
		{
			await connection.SendPacket(305);
		}
	}
}
