using System.Threading.Tasks;
using March7thHoney.Enums.Avatar;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(336)]
public class HandlerSetMultipleAvatarPathsCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetMultipleAvatarPathsCsReq setMultipleAvatarPathsCsReq = SetMultipleAvatarPathsCsReq.Parser.ParseFrom(data);
		foreach (MultiPathAvatarType avatarId in setMultipleAvatarPathsCsReq.AvatarIdList)
		{
			int num = (int)avatarId;
			int baseAvatarId = connection.Player.AvatarManager.GetFormalAvatar(num).BaseAvatarId;
			if (baseAvatarId == 8001 && num % 2 == 0)
			{
				num--;
			}
			await connection.Player.ChangeAvatarPathType(baseAvatarId, (MultiPathAvatarTypeEnum)num);
		}
		await connection.SendPacket(303);
	}
}
