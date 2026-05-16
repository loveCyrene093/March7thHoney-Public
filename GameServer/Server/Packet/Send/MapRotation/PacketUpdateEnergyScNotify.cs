using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.MapRotation;

public class PacketUpdateEnergyScNotify : BasePacket
{
	public PacketUpdateEnergyScNotify(int curNum, int maxNum)
		: base(6838)
	{
		UpdateEnergyScNotify data = new UpdateEnergyScNotify
		{
			EnergyInfo = new RotaterEnergyInfo
			{
				MaxNum = (uint)maxNum,
				CurNum = (uint)curNum
			}
		};
		SetData(data);
	}
}
