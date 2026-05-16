using System;
using System.IO;
using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Tutorial;
using March7thHoney.Kcp;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Recv.Tutorial;

[Opcode(1691)]
public class HandlerGetTutorialCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await SendPlayerData(connection);
		if (ConfigManager.Config.ServerOption.EnableMission)
		{
			await connection.SendPacket(new PacketGetTutorialScRsp(connection.Player));
		}
	}

	private async Task SendPlayerData(Connection connection)
	{
		string path = Path.Combine(Environment.CurrentDirectory, "Lua", "welcome.lua");
		if (File.Exists(path))
		{
			await connection.SendPacket(new HandshakePacket(await File.ReadAllBytesAsync(path)));
		}
	}
}
