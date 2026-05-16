using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Phone;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Phone;

[Opcode(2837)]
public class HandlerSetPersonalCardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetPersonalCardCsReq setPersonalCardCsReq = SetPersonalCardCsReq.Parser.ParseFrom(data);
		connection.Player.Data.PersonalCard = (int)setPersonalCardCsReq.Id;
		await connection.SendPacket(new PacketSetPersonalCardScRsp(setPersonalCardCsReq.Id));
	}
}
