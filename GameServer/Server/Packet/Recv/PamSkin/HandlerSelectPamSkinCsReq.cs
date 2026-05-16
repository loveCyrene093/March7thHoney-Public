using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PamSkin;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.PamSkin;

[Opcode(8122)]
public class HandlerSelectPamSkinCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SelectPamSkinCsReq selectPamSkinCsReq = SelectPamSkinCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		if (GameData.PamSkinConfigData.ContainsKey((int)selectPamSkinCsReq.PamSkin))
		{
			player.Data.CurrentPamSkin = (int)selectPamSkinCsReq.PamSkin;
		}
		int currentPamSkin = player.Data.CurrentPamSkin;
		await connection.SendPacket(new PacketSelectPamSkinScRsp(player, currentPamSkin));
	}
}
