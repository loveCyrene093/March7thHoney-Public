using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Activity.Activities.DiceCombat;
using March7thHoney.GameServer.Server.Packet.Send.DiceCombat;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.DiceCombat;

[Opcode(9289)]
public class HandlerDiceCombatUpgradeAvatarCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DiceCombatUpgradeAvatarCsReq diceCombatUpgradeAvatarCsReq = DiceCombatUpgradeAvatarCsReq.Parser.ParseFrom(data);
		DiceCombatActivityInstance diceCombat = connection.Player.ActivityManager.DiceCombat;
		await connection.SendPacket(new PacketUpgradeAvatarRsp(diceCombat, diceCombatUpgradeAvatarCsReq.AvatarId));
	}
}
