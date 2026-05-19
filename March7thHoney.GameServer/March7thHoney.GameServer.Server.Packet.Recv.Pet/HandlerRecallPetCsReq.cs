using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Pet;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Pet;

[Opcode(7603)]
public class HandlerRecallPetCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		RecallPetCsReq recallPetCsReq = RecallPetCsReq.Parser.ParseFrom(data);
		connection.Player.Data.Pet = 0;
		await connection.SendPacket(new PacketRecallPetScRsp(recallPetCsReq.SummonedPetId));
		await connection.Player.TrainCakeCatchManager.BroadcastPlayerStateAsync();
	}
}
