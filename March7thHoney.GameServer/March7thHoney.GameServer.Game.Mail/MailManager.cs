using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Database;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Mail;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Mail;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
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

	public List<uint> GetMailIdsWithAttachments()
	{
		return (from mail in MailData.MailList
			where mail.Attachment.Items.Count > 0
			select (uint)mail.MailID).ToList();
	}

	public void DeleteMail(int mailId)
	{
		int num = MailData.MailList.FindIndex((MailInfo x) => x.MailID == mailId);
		if (num >= 0)
		{
			MailData.MailList.RemoveAt(num);
		}
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

	public async ValueTask<TakeMailAttachmentResult> TakeAttachments(IEnumerable<uint> mailIds)
	{
		TakeMailAttachmentResult result = new TakeMailAttachmentResult();
		foreach (uint mailId in mailIds.Distinct())
		{
			MailInfo mail = GetMail((int)mailId);
			if (mail == null)
			{
				result.FailedMails.Add(new TakeMailAttachmentFailInfo(mailId, Retcode.RetMailMailIdInvalid));
				continue;
			}
			if (mail.Attachment.Items.Count == 0)
			{
				result.FailedMails.Add(new TakeMailAttachmentFailInfo(mailId, Retcode.RetMailNoMailTakeAttachment));
				continue;
			}
			if (mail.Attachment.Items.Any((ItemData item) => item.ItemId <= 0 || item.Count <= 0 || !GameData.ItemConfigData.ContainsKey(item.ItemId)))
			{
				result.FailedMails.Add(new TakeMailAttachmentFailInfo(mailId, Retcode.RetMailAttachementInvalid));
				continue;
			}
			List<ItemData> grantedItems = new List<ItemData>();
			foreach (ItemData item in mail.Attachment.Items)
			{
				ItemData itemData = await base.Player.InventoryManager.AddItem(item.ItemId, item.Count, notify: false, item.Rank, item.Level, item.Promotion, sync: false, returnRaw: true);
				if (itemData != null)
				{
					grantedItems.Add(itemData);
				}
			}
			if (grantedItems.Count != mail.Attachment.Items.Count)
			{
				result.FailedMails.Add(new TakeMailAttachmentFailInfo(mailId, Retcode.RetMailAttachementInvalid));
				continue;
			}
			result.Attachment.Items.AddRange(grantedItems);
			result.SuccessMailIds.Add(mailId);
			mail.Attachment.Items.Clear();
			mail.IsRead = true;
		}
		if (result.SuccessMailIds.Count > 0)
		{
			DatabaseHelper.ToSaveUidList.SafeAdd(base.Player.Uid);
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(result.Attachment.Items));
		}
		return result;
	}
}
