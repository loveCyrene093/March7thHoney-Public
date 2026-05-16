namespace March7thHoney.Internationalization.Message;

public class AccountTextCHS
{
	public string Desc => "创建账号\n注意：此命令未经测试，请谨慎使用！";

	public string Usage => "用法：/account create [用户名]";

	public string InvalidUid => "无效UID参数！";

	public string CreateError => "出现内部错误 {0} ";

	public string CreateSuccess => "新账号 {0} 创建成功!";

	public string DuplicateAccount => "账号 {0} 已存在!";

	public string DuplicateUID => "UID {0} 已存在!";

	public string DataError => "新账号获取失败! {0}!";
}
