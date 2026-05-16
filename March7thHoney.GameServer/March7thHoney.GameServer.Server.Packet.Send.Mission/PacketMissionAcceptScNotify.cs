using System.Collections.Generic;
using System.Runtime.InteropServices;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mission;

public class PacketMissionAcceptScNotify : BasePacket
{
	public PacketMissionAcceptScNotify(int missionId)
	{
		int num = 1;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = missionId;
		this._002Ector(list);
	}

	public PacketMissionAcceptScNotify(List<int> missionIds)
		: base(1251)
	{
		MainMissionAcceptNotify mainMissionAcceptNotify = new MainMissionAcceptNotify();
		foreach (int missionId in missionIds)
		{
			mainMissionAcceptNotify.SubMissionIdList.Add((uint)missionId);
		}
		SetData(mainMissionAcceptNotify);
	}
}
