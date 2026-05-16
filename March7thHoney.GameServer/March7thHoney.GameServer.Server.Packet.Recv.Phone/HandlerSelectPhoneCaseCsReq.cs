using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Phone;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Phone;

[Opcode(5163)]
public class HandlerSelectPhoneCaseCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SelectPhoneCaseCsReq selectPhoneCaseCsReq = SelectPhoneCaseCsReq.Parser.ParseFrom(data);
		connection.Player.Data.PhoneCase = (int)selectPhoneCaseCsReq.PhoneCaseId;
		await connection.SendPacket(new PacketSelectPhoneCaseScRsp(selectPhoneCaseCsReq.PhoneCaseId));
	}
}
