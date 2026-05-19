using System;
using System.Collections.Generic;
using System.Linq;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mail;

public class PacketGetMailScRsp : BasePacket
{
	private const int DefaultPageSize = 50;

	public PacketGetMailScRsp(PlayerInstance player, uint start = 0u, uint requestedCount = 0u)
		: base(810)
	{
		List<(ClientMail, bool)> list = (from mail in player.MailManager.ToMailProto()
			select (Mail: mail, IsNotice: false)).Concat(from mail in player.MailManager.ToNoticeMailProto()
			select (Mail: mail, IsNotice: true)).ToList();
		int count = (int)((requestedCount == 0) ? 50 : Math.Min(requestedCount, 50u));
		int num = (int)Math.Min(start, (uint)list.Count);
		List<(ClientMail, bool)> list2 = list.Skip(num).Take(count).ToList();
		GetMailScRsp getMailScRsp = new GetMailScRsp
		{
			Start = start,
			IsEnd = (num + list2.Count >= list.Count),
			TotalNum = Math.Max((uint)list.Count, start)
		};
		getMailScRsp.MailList.AddRange(from mail in list2
			where !mail.IsNotice
			select mail.Mail);
		getMailScRsp.NoticeMailList.AddRange(from mail in list2
			where mail.IsNotice
			select mail.Mail);
		SetData(getMailScRsp);
	}
}
