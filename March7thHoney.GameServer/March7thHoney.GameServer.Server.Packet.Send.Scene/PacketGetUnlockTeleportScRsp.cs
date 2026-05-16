using System.Collections.Generic;
using March7thHoney.Data;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketGetUnlockTeleportScRsp : BasePacket
{
	public PacketGetUnlockTeleportScRsp(GetUnlockTeleportCsReq req)
		: base(1483)
	{
		GetUnlockTeleportScRsp getUnlockTeleportScRsp = new GetUnlockTeleportScRsp();
		foreach (uint entryId in req.EntryIdList)
		{
			GameData.MapEntranceData.TryGetValue((int)entryId, out MapEntranceExcel value);
			if (value == null)
			{
				continue;
			}
			GameData.GetFloorInfo(value.PlaneID, value.FloorID, out FloorInfo outer);
			if (outer == null)
			{
				continue;
			}
			foreach (KeyValuePair<int, PropInfo> cachedTeleport in outer.CachedTeleports)
			{
				getUnlockTeleportScRsp.UnlockTeleportList.Add((uint)cachedTeleport.Value.MappingInfoID);
			}
		}
		SetData(getUnlockTeleportScRsp);
	}
}
