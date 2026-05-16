using March7thHoney.GameServer.Game.Scene;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketEnterSceneByServerScNotify : BasePacket
{
	public PacketEnterSceneByServerScNotify(SceneInstance scene)
		: base(1468)
	{
		SceneInfo scene2 = scene.ToProto();
		EnterSceneByServerScNotify data = new EnterSceneByServerScNotify
		{
			Scene = scene2,
			Lineup = scene.Player.LineupManager.GetCurLineup().ToProto()
		};
		SetData(data);
	}
}
