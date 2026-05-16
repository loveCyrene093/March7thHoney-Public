using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Phone;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Phone;

[Opcode(5118)]
public class HandlerSelectPhoneThemeCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SelectPhoneThemeCsReq selectPhoneThemeCsReq = SelectPhoneThemeCsReq.Parser.ParseFrom(data);
		connection.Player.Data.PhoneTheme = (int)selectPhoneThemeCsReq.ThemeId;
		await connection.SendPacket(new PacketSelectPhoneThemeScRsp(selectPhoneThemeCsReq.ThemeId));
	}
}
