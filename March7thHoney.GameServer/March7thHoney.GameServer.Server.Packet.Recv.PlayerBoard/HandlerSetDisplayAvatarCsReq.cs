using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Avatar;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerBoard;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.PlayerBoard;

[Opcode(2814)]
public class HandlerSetDisplayAvatarCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetDisplayAvatarCsReq setDisplayAvatarCsReq = SetDisplayAvatarCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		List<int> displayAvatars = player.AvatarManager.AvatarData.DisplayAvatars;
		displayAvatars.Clear();
		foreach (DisplayAvatarData avatar in setDisplayAvatarCsReq.DisplayAvatarList)
		{
			if (avatar.AvatarId != 0)
			{
				FormalAvatarInfo formalAvatarInfo = player.AvatarManager.AvatarData.FormalAvatars.FirstOrDefault((FormalAvatarInfo x) => x.BaseAvatarId == (int)avatar.AvatarId);
				if (formalAvatarInfo != null)
				{
					displayAvatars.Add(formalAvatarInfo.BaseAvatarId);
				}
			}
		}
		await connection.SendPacket(new PacketSetDisplayAvatarScRsp(setDisplayAvatarCsReq.DisplayAvatarList));
	}
}
