using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1417)]
public class HandlerSetGroupCustomSaveDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetGroupCustomSaveDataCsReq setGroupCustomSaveDataCsReq = SetGroupCustomSaveDataCsReq.Parser.ParseFrom(data);
		connection.Player.SetCustomSaveData((int)setGroupCustomSaveDataCsReq.EntryId, (int)setGroupCustomSaveDataCsReq.GroupId, setGroupCustomSaveDataCsReq.SaveData);
		await connection.SendPacket(new PacketSetGroupCustomSaveDataScRsp(setGroupCustomSaveDataCsReq.EntryId, setGroupCustomSaveDataCsReq.GroupId));
	}
}
