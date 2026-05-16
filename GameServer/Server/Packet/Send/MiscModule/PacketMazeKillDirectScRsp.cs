using System.Collections.Generic;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.MiscModule;

public class PacketMazeKillDirectScRsp : BasePacket
{
	public PacketMazeKillDirectScRsp(List<uint> entityIds)
		: base(4117)
	{
		MazeKillDirectScRsp data = new MazeKillDirectScRsp
		{
			EntityList = { (IEnumerable<uint>)entityIds }
		};
		SetData(data);
	}
}
