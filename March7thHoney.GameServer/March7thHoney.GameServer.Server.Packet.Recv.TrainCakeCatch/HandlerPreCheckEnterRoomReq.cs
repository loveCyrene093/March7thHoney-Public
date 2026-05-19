using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Recv.TrainCakeCatch;

[Opcode(9767)]
public class HandlerPreCheckEnterRoomReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PreCheckEnterRoomReq preCheckEnterRoomReq = PreCheckEnterRoomReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		uint num = ResolveRoomOwnerUid(player.Uid, preCheckEnterRoomReq.TeleportId);
		player.TrainCakeCatchManager.PrepareSocialPlayRoom(num);
		BasePacket basePacket = new BasePacket(9728);
		basePacket.SetData(new SocialPlayPreCheckEnterRoomScRsp
		{
			DHLGCEGONIB = player.TrainCakeCatchManager.GetRoomRefreshTime(num)
		});
		await connection.SendPacket(basePacket);
	}

	private static uint ResolveRoomOwnerUid(int playerUid, uint teleportId)
	{
		if (teleportId == 0)
		{
			return (uint)playerUid;
		}
		uint uid = (uint)ConfigManager.Config.ServerOption.ServerProfile.Uid;
		if (teleportId == uid)
		{
			return (uint)playerUid;
		}
		return teleportId;
	}
}
