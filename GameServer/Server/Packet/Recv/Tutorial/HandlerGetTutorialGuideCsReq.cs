using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Tutorial;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Recv.Tutorial;

[Opcode(1694)]
public class HandlerGetTutorialGuideCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		if (ConfigManager.Config.ServerOption.EnableMission)
		{
			await connection.SendPacket(new PacketGetTutorialGuideScRsp(connection.Player));
		}
	}
}
