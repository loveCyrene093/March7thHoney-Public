using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Avatar;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerBoard;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.PlayerBoard;

[Opcode(2801)]
public class HandlerSetAssistAvatarCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetAssistAvatarCsReq setAssistAvatarCsReq = SetAssistAvatarCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		List<int> assistAvatars = player.AvatarManager.AvatarData.AssistAvatars;
		assistAvatars.Clear();
		foreach (uint id in setAssistAvatarCsReq.AvatarIdList)
		{
			if (id != 0)
			{
				FormalAvatarInfo formalAvatarInfo = player.AvatarManager.AvatarData.FormalAvatars.FirstOrDefault((FormalAvatarInfo x) => x.BaseAvatarId == (int)id);
				if (formalAvatarInfo != null)
				{
					assistAvatars.Add(formalAvatarInfo.BaseAvatarId);
				}
			}
		}
		await connection.SendPacket(new PacketSetAssistAvatarScRsp(setAssistAvatarCsReq.AvatarIdList));
	}
}
