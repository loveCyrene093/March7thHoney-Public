using System.Linq;
using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Gacha;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Gacha;

[Opcode(1963)]
public class HandlerSetGachaDecideItemCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetGachaDecideItemCsReq setGachaDecideItemCsReq = SetGachaDecideItemCsReq.Parser.ParseFrom(data);
		connection.Player.GachaManager.GachaData.GachaDecideOrder = setGachaDecideItemCsReq.DGOMHDMJHEK.Select((uint x) => (int)x).ToList();
		await connection.SendPacket(new PacketSetGachaDecideItemScRsp(setGachaDecideItemCsReq.GachaId, setGachaDecideItemCsReq.DGOMHDMJHEK.ToList()));
	}
}
