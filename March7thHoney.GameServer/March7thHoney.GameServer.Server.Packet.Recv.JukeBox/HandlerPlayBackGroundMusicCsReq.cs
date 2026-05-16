using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.JukeBox;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.JukeBox;

[Opcode(3194)]
public class HandlerPlayBackGroundMusicCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		uint valueOrDefault = (PlayBackGroundMusicCsReq.Parser.ParseFrom(data).DMGCIDGKPFF?.LEKGBMCOJDB?.Id).GetValueOrDefault();
		connection.Player.Data.CurrentBgm = (int)valueOrDefault;
		await connection.SendPacket(new PacketPlayBackGroundMusicScRsp(valueOrDefault));
	}
}
