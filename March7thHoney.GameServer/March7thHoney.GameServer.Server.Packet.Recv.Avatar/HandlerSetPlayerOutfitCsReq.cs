using System.Threading.Tasks;
using March7thHoney.Database;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Avatar;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Recv.Avatar;

[Opcode(302)]
public class HandlerSetPlayerOutfitCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SetPlayerOutfitCsReq setPlayerOutfitCsReq = SetPlayerOutfitCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		player.Data.PlayerOutfitList.Clear();
		if (setPlayerOutfitCsReq.PlayerOutfitData != null)
		{
			foreach (uint playerOutfit in setPlayerOutfitCsReq.PlayerOutfitData.PlayerOutfitList)
			{
				player.Data.PlayerOutfitList.Add((int)playerOutfit);
			}
		}
		DatabaseHelper.ToSaveUidList.SafeAdd(player.Uid);
		await connection.SendPacket(new PacketPlayerSyncScNotify(player.Data.ToPlayerOutfitProto()));
		await connection.SendPacket(new PacketSetPlayerOutfitScRsp());
		await player.TrainCakeCatchManager.BroadcastPlayerStateAsync();
	}
}
