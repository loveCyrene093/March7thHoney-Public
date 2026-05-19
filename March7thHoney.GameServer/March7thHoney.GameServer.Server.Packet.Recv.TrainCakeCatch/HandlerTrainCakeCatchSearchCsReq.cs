using System.Threading.Tasks;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainCakeCatch;

[Opcode(9733)]
public class HandlerTrainCakeCatchSearchCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TrainCakeCatchSearchCsReq trainCakeCatchSearchCsReq = TrainCakeCatchSearchCsReq.Parser.ParseFrom(data);
		BasePacket basePacket = new BasePacket(9766);
		basePacket.SetData(connection.Player.TrainCakeCatchManager.Search(trainCakeCatchSearchCsReq.HCJPDNDOHAM));
		await connection.SendPacket(basePacket);
	}
}
