using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Sync.Player;

public class PlayerBoardSync : BaseSyncData
{
	public PlayerBoardSync(PlayerInstance player)
	{
		_003Cplayer_003EP = player;
		base._002Ector();
	}

	public override void SyncData(in PlayerSyncScNotify notify)
	{
		notify.PlayerboardModuleSync = new PlayerBoardModuleSync
		{
			Signature = _003Cplayer_003EP.Data.Signature,
			HeadFrameInfo = _003Cplayer_003EP.Data.HeadFrame.ToProto()
		};
	}
}
