using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1494)]
public class HandlerInteractPropCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		InteractPropCsReq interactPropCsReq = InteractPropCsReq.Parser.ParseFrom(data);
		int interactId = (int)((interactPropCsReq.InteractId2 != 0) ? interactPropCsReq.InteractId2 : interactPropCsReq.InteractId);
		await connection.SendPacket(new PacketInteractPropScRsp(await connection.Player.InteractProp((int)interactPropCsReq.PropEntityId, interactId)));
	}
}
