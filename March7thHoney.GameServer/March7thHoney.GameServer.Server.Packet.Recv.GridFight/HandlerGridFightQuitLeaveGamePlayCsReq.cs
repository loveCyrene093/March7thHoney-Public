using System.Threading.Tasks;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.GridFight;

[Opcode(8458)]
public class HandlerGridFightQuitLeaveGamePlayCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GridFightQuitLeaveGamePlayCsReq.Parser.ParseFrom(data);
		connection.Player.GridFightManager.GridFightInstance = null;
		BasePacket basePacket = new BasePacket(8583);
		basePacket.SetData(new CENLNIAOMAK());
		await connection.SendPacket(basePacket);
	}
}
