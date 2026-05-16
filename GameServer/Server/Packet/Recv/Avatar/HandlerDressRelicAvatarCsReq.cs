using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(338)]
public class HandlerDressRelicAvatarCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DressRelicAvatarCsReq req = DressRelicAvatarCsReq.Parser.ParseFrom(data);
		foreach (DressRelicParam @switch in req.SwitchList)
		{
			await connection.Player.InventoryManager.EquipRelic((int)req.AvatarId, (int)@switch.RelicUniqueId, (int)@switch.RelicType);
		}
		await connection.SendPacket(372);
	}
}
