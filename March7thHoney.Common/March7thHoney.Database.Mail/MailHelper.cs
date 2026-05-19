using System;
using System.Linq;
using March7thHoney.Configuration;
using March7thHoney.Database.Inventory;
using March7thHoney.Util;

namespace March7thHoney.Database.Mail;

public static class MailHelper
{
	public static void SendWelcomeMail(int uid, string username)
	{
		WelcomeMailConfig welcomeMail = ConfigManager.Config.ServerOption.WelcomeMail;
		if (!welcomeMail.Enabled)
		{
			return;
		}
		MailData mailData = DatabaseHelper.Instance?.GetInstanceOrCreateNew<MailData>(uid);
		if (mailData != null)
		{
			DateTime now = DateTime.Now;
			MailInfo item = new MailInfo
			{
				MailID = mailData.NextMailId++,
				SenderName = FormatText(welcomeMail.Sender, uid, username),
				Title = FormatText(welcomeMail.Title, uid, username),
				Content = FormatText(welcomeMail.Content, uid, username),
				TemplateID = welcomeMail.TemplateId,
				SendTime = now.ToUnixSec(),
				ExpireTime = now.AddDays(Math.Max(welcomeMail.ExpireDays, 1)).ToUnixSec(),
				IsStar = welcomeMail.IsStar,
				Attachment = new MailAttachmentInfo
				{
					Items = (from welcomeMailItemConfig in welcomeMail.Items
						where welcomeMailItemConfig.ItemId > 0 && welcomeMailItemConfig.Count > 0
						select new ItemData
						{
							ItemId = welcomeMailItemConfig.ItemId,
							Count = welcomeMailItemConfig.Count,
							Rank = welcomeMailItemConfig.Rank,
							Level = welcomeMailItemConfig.Level,
							Promotion = welcomeMailItemConfig.Promotion
						}).ToList()
				}
			};
			mailData.MailList.Add(item);
			DatabaseHelper.SaveDatabaseType(mailData);
		}
	}

	private static string FormatText(string value, int uid, string username)
	{
		return value.Replace("{uid}", uid.ToString()).Replace("{username}", username).Replace("{account}", username);
	}
}
