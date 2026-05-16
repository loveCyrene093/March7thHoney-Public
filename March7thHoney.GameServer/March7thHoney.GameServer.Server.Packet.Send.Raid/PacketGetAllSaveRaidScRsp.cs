using System.Collections.Generic;
using March7thHoney.Database.Scene;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Raid;

public class PacketGetAllSaveRaidScRsp : BasePacket
{
	public PacketGetAllSaveRaidScRsp(PlayerInstance player)
		: base(2216)
	{
		GetAllSaveRaidScRsp getAllSaveRaidScRsp = new GetAllSaveRaidScRsp();
		foreach (Dictionary<int, RaidRecord> value in player.RaidManager.RaidData.RaidRecordDatas.Values)
		{
			foreach (RaidRecord value2 in value.Values)
			{
				getAllSaveRaidScRsp.RaidDataList.Add(new March7thHoney.Proto.RaidData
				{
					RaidId = (uint)value2.RaidId,
					WorldLevel = (uint)value2.WorldLevel
				});
			}
		}
		SetData(getAllSaveRaidScRsp);
	}
}
