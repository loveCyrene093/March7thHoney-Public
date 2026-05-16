using System.Collections.Generic;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketSyncEntityBuffChangeListScNotify : BasePacket
{
	public PacketSyncEntityBuffChangeListScNotify(BaseGameEntity entity, SceneBuff buff)
		: base(1474)
	{
		SyncEntityBuffChangeListScNotify syncEntityBuffChangeListScNotify = new SyncEntityBuffChangeListScNotify();
		EntityBuffChangeInfo item = new EntityBuffChangeInfo
		{
			EntityId = (uint)entity.EntityId,
			CastEntityId = (uint)buff.CastEntityId,
			Reason = buff.ChangeReason,
			BuffChangeInfo = buff.ToProto()
		};
		syncEntityBuffChangeListScNotify.EntityBuffChangeList.Add(item);
		SetData(syncEntityBuffChangeListScNotify);
	}

	public PacketSyncEntityBuffChangeListScNotify(BaseGameEntity entity, List<SceneBuff> buffs)
		: base(1474)
	{
		SyncEntityBuffChangeListScNotify syncEntityBuffChangeListScNotify = new SyncEntityBuffChangeListScNotify();
		foreach (SceneBuff buff in buffs)
		{
			EntityBuffChangeInfo item = new EntityBuffChangeInfo
			{
				EntityId = (uint)entity.EntityId,
				RemoveBuffId = (uint)buff.BuffId
			};
			syncEntityBuffChangeListScNotify.EntityBuffChangeList.Add(item);
		}
		SetData(syncEntityBuffChangeListScNotify);
	}
}
