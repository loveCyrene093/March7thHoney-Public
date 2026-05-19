using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketEnterSceneScRsp : BasePacket
{
	public PacketEnterSceneScRsp(bool overMapTp = false, bool tpByMap = false, int storyLineId = 0, uint floorId = 0u, uint teleportId = 0u)
		: base(1470)
	{
		SceneIdentifier sceneIdentifier = new SceneIdentifier
		{
			FloorId = floorId,
			GameStoryLineId = (uint)storyLineId
		};
		if (teleportId != 0)
		{
			sceneIdentifier.TeleportInfo = new TeleportInfo
			{
				TeleportId = teleportId
			};
		}
		EnterSceneScRsp data = new EnterSceneScRsp
		{
			IsCloseMap = tpByMap,
			IsOverMap = overMapTp,
			SceneIdentifier = sceneIdentifier
		};
		SetData(data);
	}

	public PacketEnterSceneScRsp(Retcode retcode)
		: base(1470)
	{
		EnterSceneScRsp data = new EnterSceneScRsp
		{
			Retcode = (uint)retcode
		};
		SetData(data);
	}
}
