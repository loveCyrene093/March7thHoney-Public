using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerBoard;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.PlayerBoard;

[Opcode(2894)]
public class HandlerSetHeadIconCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerInstance player = connection.Player;
		SetHeadIconCsReq setHeadIconCsReq = SetHeadIconCsReq.Parser.ParseFrom(data);
		if (setHeadIconCsReq != null)
		{
			player.Data.HeadIcon = (int)setHeadIconCsReq.Id;
			await connection.SendPacket(new PacketSetHeadIconScRsp(player));
		}
	}
}
