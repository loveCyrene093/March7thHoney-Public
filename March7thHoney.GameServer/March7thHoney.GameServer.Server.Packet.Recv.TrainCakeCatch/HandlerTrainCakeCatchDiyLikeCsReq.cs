using System.Threading.Tasks;
using March7thHoney.Kcp;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainCakeCatch;

[Opcode(9659)]
public class HandlerTrainCakeCatchDiyLikeCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		BasePacket basePacket = new BasePacket(9697);
		basePacket.SetData(connection.Player.TrainCakeCatchManager.LikeDiy());
		await connection.SendPacket(basePacket);
	}
}
