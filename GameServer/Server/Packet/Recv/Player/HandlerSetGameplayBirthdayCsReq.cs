using System.Threading.Tasks;
using March7thHoney.Database.Player;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(92)]
public class HandlerSetGameplayBirthdayCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetGameplayBirthdayCsReq setGameplayBirthdayCsReq = SetGameplayBirthdayCsReq.Parser.ParseFrom(data);
		uint num = setGameplayBirthdayCsReq.Birthday / 100;
		uint num2 = setGameplayBirthdayCsReq.Birthday % 100;
		if (num < 1 || num > 12 || num2 < 1 || num2 > 31)
		{
			await connection.SendPacket(new PacketSetGameplayBirthdayScRsp());
			return;
		}
		PlayerData data2 = connection.Player.Data;
		if (data2.Birthday != 0)
		{
			await connection.SendPacket(new PacketSetGameplayBirthdayScRsp());
			return;
		}
		data2.Birthday = (int)setGameplayBirthdayCsReq.Birthday;
		await connection.SendPacket(new PacketSetGameplayBirthdayScRsp(setGameplayBirthdayCsReq.Birthday));
	}
}
