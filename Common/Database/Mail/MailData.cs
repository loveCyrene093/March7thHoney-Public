using System.Collections.Generic;
using SqlSugar;

namespace March7thHoney.Database.Mail;

[SugarTable("Mail")]
public class MailData : BaseDatabaseDataHelper
{
	[SugarColumn(IsJson = true)]
	public List<MailInfo> MailList { get; set; } = new List<MailInfo>();

	[SugarColumn(IsJson = true)]
	public List<MailInfo> NoticeMailList { get; set; } = new List<MailInfo>();

	public int NextMailId { get; set; } = 1;
}
