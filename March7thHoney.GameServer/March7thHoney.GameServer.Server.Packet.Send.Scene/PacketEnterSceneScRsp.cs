using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketEnterSceneScRsp : BasePacket
{
	public PacketEnterSceneScRsp(bool overMapTp = false, bool tpByMap = false, int storyLineId = 0)
		: base(1470)
	{
		EnterSceneScRsp data = new EnterSceneScRsp
		{
			IsCloseMap = tpByMap,
			IsOverMap = overMapTp,
			SceneIdentifier = new SceneIdentifier
			{
				GameStoryLineId = (uint)storyLineId
			}
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
