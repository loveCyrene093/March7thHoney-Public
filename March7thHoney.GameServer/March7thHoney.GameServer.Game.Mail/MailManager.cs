using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Database;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Mail;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Mail;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Mail;

public class MailManager : BasePlayerManager
{
	public MailData MailData { get; }

	public MailManager(PlayerInstance player)
	{
		MailData = DatabaseHelper.Instance.GetInstanceOrCreateNew<MailData>(player.Uid);
		base._002Ector(player);
	}

	public List<MailInfo> GetMailList()
	{
		return MailData.MailList;
	}

	public MailInfo? GetMail(int mailId)
	{
		return MailData.MailList.Find((MailInfo x) => x.MailID == mailId);
	}

	public void DeleteMail(int mailId)
	{
		int index = MailData.MailList.FindIndex((MailInfo x) => x.MailID == mailId);
		MailData.MailList.RemoveAt(index);
	}

	public async ValueTask SendMail(string sender, string title, string content, int templateId, int expiredDay = 30)
	{
		MailInfo mailInfo = new MailInfo
		{
			MailID = MailData.NextMailId++,
			SenderName = sender,
			Content = content,
			Title = title,
			TemplateID = templateId,
			SendTime = DateTime.Now.ToUnixSec(),
			ExpireTime = DateTime.Now.AddDays(expiredDay).ToUnixSec()
		};
		MailData.MailList.Add(mailInfo);
		await base.Player.SendPacket(new PacketNewMailScNotify(mailInfo.MailID));
	}

	public async ValueTask SendMail(string sender, string title, string content, int templateId, List<ItemData> attachments, int expiredDay = 30)
	{
		MailInfo mailInfo = new MailInfo
		{
			MailID = MailData.NextMailId++,
			SenderName = sender,
			Content = content,
			Title = title,
			TemplateID = templateId,
			SendTime = DateTime.Now.ToUnixSec(),
			ExpireTime = DateTime.Now.AddDays(expiredDay).ToUnixSec(),
			Attachment = new MailAttachmentInfo
			{
				Items = attachments
			}
		};
		MailData.MailList.Add(mailInfo);
		await base.Player.SendPacket(new PacketNewMailScNotify(mailInfo.MailID));
	}

	public List<ClientMail> ToMailProto()
	{
		List<ClientMail> list = new List<ClientMail>();
		foreach (MailInfo mail in MailData.MailList)
		{
			list.Add(mail.ToProto());
		}
		return list;
	}

	public List<ClientMail> ToNoticeMailProto()
	{
		List<ClientMail> list = new List<ClientMail>();
		foreach (MailInfo noticeMail in MailData.NoticeMailList)
		{
			list.Add(noticeMail.ToProto());
		}
		return list;
	}
}
