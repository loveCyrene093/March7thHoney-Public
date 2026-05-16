using System.Collections.Generic;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mail;

public class PacketGetMailScRsp : BasePacket
{
	public PacketGetMailScRsp(PlayerInstance player)
		: base(810)
	{
		List<ClientMail> list = player.MailManager.ToMailProto();
		List<ClientMail> list2 = player.MailManager.ToNoticeMailProto();
		GetMailScRsp data = new GetMailScRsp
		{
			IsEnd = true,
			MailList = { (IEnumerable<ClientMail>)list },
			NoticeMailList = { (IEnumerable<ClientMail>)list2 },
			TotalNum = (uint)(list.Count + list2.Count)
		};
		SetData(data);
	}
}
