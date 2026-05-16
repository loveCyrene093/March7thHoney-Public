using System.Threading.Tasks;
using March7thHoney.Enums.Avatar;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(93)]
public class HandlerSetPlayerInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerInstance player = connection.Player;
		SetPlayerInfoCsReq req = SetPlayerInfoCsReq.Parser.ParseFrom(data);
		if (req == null)
		{
			return;
		}
		player.Data.Name = req.Nickname;
		if (req.Gender == Gender.None)
		{
			await connection.SendPacket(new PacketSetPlayerInfoScRsp(player, req.IsModify));
			await connection.SendWatermarkLuaAsync();
			return;
		}
		if (req.Gender == Gender.Woman)
		{
			player.Data.CurrentGender = Gender.Woman;
		}
		else
		{
			player.Data.CurrentGender = Gender.Man;
		}
		player.Data.IsGenderSet = true;
		await player.ChangeAvatarPathType(8001, MultiPathAvatarTypeEnum.Warrior);
		await player.LineupManager.AddAvatarToCurTeam(8001);
		await player.LineupManager.AddAvatarToCurTeam(1001);
		await player.MissionManager.FinishSubMission(100010134);
		await connection.SendPacket(new PacketSetPlayerInfoScRsp(player, req.IsModify));
		await connection.SendPacket(new PacketPlayerSyncScNotify(player.ToProto()));
		await connection.SendWatermarkLuaAsync();
	}
}
