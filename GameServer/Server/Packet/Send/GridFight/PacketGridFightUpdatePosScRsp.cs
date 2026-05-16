using System.Collections.Generic;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightUpdatePosScRsp : BasePacket
{
	public PacketGridFightUpdatePosScRsp(IEnumerable<GridFightPosInfo>? posInfoList = null)
		: base(8578)
	{
		GridFightUpdatePosScRsp gridFightUpdatePosScRsp = new GridFightUpdatePosScRsp();
		if (posInfoList != null)
		{
			gridFightUpdatePosScRsp.GridFightPosInfoList.AddRange(posInfoList);
		}
		SetData(gridFightUpdatePosScRsp);
	}
}
