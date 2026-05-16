using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Activity.Activities.DiceCombat;
using March7thHoney.GameServer.Server.Packet.Send.DiceCombat;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.DiceCombat;

[Opcode(9268)]
public class HandlerDiceCombatModifyAvatarDiceCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DiceCombatModifyAvatarDiceCsReq diceCombatModifyAvatarDiceCsReq = DiceCombatModifyAvatarDiceCsReq.Parser.ParseFrom(data);
		DiceCombatActivityInstance diceCombat = connection.Player.ActivityManager.DiceCombat;
		await connection.SendPacket(new PacketModifyAvatarDiceRsp(diceCombat, diceCombatModifyAvatarDiceCsReq.AvatarId));
	}
}
