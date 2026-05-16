using System.Threading.Tasks;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainCakeCatch;

[Opcode(9628)]
public class HandlerTrainCakeCatchOpenBoxCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		BasePacket basePacket = new BasePacket(9657);
		basePacket.SetData(new TrainCakeCatchOpenBoxScRsp());
		await connection.SendPacket(basePacket);
	}
}
