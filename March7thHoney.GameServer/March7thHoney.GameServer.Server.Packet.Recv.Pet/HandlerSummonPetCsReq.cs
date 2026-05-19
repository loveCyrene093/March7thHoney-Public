using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Pet;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Pet;

[Opcode(7602)]
public class HandlerSummonPetCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SummonPetCsReq req = SummonPetCsReq.Parser.ParseFrom(data);
		int curPetId = connection.Player.Data.Pet;
		if (curPetId != req.SummonedPetId && curPetId != 0)
		{
			await connection.SendPacket(new PacketCurPetChangedScNotify(req.SummonedPetId));
		}
		connection.Player.Data.Pet = (int)req.SummonedPetId;
		await connection.SendPacket(new PacketSummonPetScRsp(curPetId, req.SummonedPetId));
		await connection.Player.TrainCakeCatchManager.BroadcastPlayerStateAsync();
	}
}
