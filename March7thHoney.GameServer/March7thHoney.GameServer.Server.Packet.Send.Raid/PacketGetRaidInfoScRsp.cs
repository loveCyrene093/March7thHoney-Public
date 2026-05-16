using System.Collections.Generic;
using March7thHoney.Database.Scene;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Raid;

public class PacketGetRaidInfoScRsp : BasePacket
{
	public PacketGetRaidInfoScRsp(PlayerInstance player)
		: base(2244)
	{
		GetRaidInfoScRsp getRaidInfoScRsp = new GetRaidInfoScRsp();
		foreach (KeyValuePair<int, Dictionary<int, RaidRecord>> raidRecordData in player.RaidManager.RaidData.RaidRecordDatas)
		{
			foreach (KeyValuePair<int, RaidRecord> item in raidRecordData.Value)
			{
				if (item.Value.Status == RaidStatus.Finish)
				{
					getRaidInfoScRsp.FinishedRaidInfoList.Add(new FinishedRaidInfo
					{
						RaidId = (uint)item.Value.RaidId,
						WorldLevel = (uint)item.Value.WorldLevel
					});
				}
			}
		}
		SetData(getRaidInfoScRsp);
	}
}
