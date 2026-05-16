using System.Collections.Generic;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Message;

public class PacketGetNpcMessageGroupScRsp : BasePacket
{
	public PacketGetNpcMessageGroupScRsp(IEnumerable<uint> contactIdList, PlayerInstance instance)
		: base(2710)
	{
		GetNpcMessageGroupScRsp getNpcMessageGroupScRsp = new GetNpcMessageGroupScRsp();
		foreach (uint contactId in contactIdList)
		{
			List<MessageGroup> messageGroup = instance.MessageManager.GetMessageGroup((int)contactId);
			getNpcMessageGroupScRsp.MessageGroupList.AddRange(messageGroup);
		}
		SetData(getNpcMessageGroupScRsp);
	}
}
