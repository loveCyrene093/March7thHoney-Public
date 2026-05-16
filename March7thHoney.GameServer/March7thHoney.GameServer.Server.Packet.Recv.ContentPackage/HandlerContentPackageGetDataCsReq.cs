using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.ContentPackage;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.ContentPackage;

[Opcode(7513)]
public class HandlerContentPackageGetDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		ContentPackageGetDataCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketContentPackageGetDataScRsp());
	}
}
