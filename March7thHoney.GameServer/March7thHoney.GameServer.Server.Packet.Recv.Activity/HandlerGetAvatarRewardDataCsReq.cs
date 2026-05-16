using System.Threading.Tasks;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Activity;

[Opcode(2690)]
public class HandlerGetAvatarRewardDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetAvatarRewardDataCsReq.Parser.ParseFrom(data);
		GetAvatarRewardDataScRsp data2 = new GetAvatarRewardDataScRsp
		{
			AvatarId = 1415u,
			IsTakenReward = false
		};
		BasePacket basePacket = new BasePacket(2669);
		basePacket.SetData(data2);
		await connection.SendPacket(basePacket);
	}
}
