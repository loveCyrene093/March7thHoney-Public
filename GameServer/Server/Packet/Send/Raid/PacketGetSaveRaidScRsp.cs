using System.Collections.Generic;
using March7thHoney.Database.Scene;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Raid;

public class PacketGetSaveRaidScRsp : BasePacket
{
	public PacketGetSaveRaidScRsp(PlayerInstance player, int raidId, int worldLevel)
		: base(2203)
	{
		GetSaveRaidScRsp getSaveRaidScRsp = new GetSaveRaidScRsp();
		if (player.RaidManager.RaidData.RaidRecordDatas.TryGetValue(raidId, out Dictionary<int, RaidRecord> value))
		{
			if (value.TryGetValue(worldLevel, out var value2))
			{
				getSaveRaidScRsp.RaidId = (uint)value2.RaidId;
				getSaveRaidScRsp.WorldLevel = (uint)value2.WorldLevel;
				getSaveRaidScRsp.IsSave = value2.Status != RaidStatus.Finish && value2.Status != RaidStatus.None;
			}
			else
			{
				getSaveRaidScRsp.Retcode = 3117u;
			}
		}
		else
		{
			getSaveRaidScRsp.Retcode = 3117u;
		}
		SetData(getSaveRaidScRsp);
	}
}
