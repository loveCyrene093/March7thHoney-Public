using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.TalkEvent;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.TalkEvent;

[Opcode(2191)]
public class HandlerGetNpcTakenRewardCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetNpcTakenRewardCsReq getNpcTakenRewardCsReq = GetNpcTakenRewardCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetNpcTakenRewardScRsp(getNpcTakenRewardCsReq.NpcId));
	}
}
