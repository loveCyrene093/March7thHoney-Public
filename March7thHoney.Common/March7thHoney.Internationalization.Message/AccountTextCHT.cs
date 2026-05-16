namespace March7thHoney.Internationalization.Message;

public class AccountTextCHT
{
	public string Desc => "創建賬號\n注意：此命令未經測試，請謹慎使用！";

	public string Usage => "用法：/account create [用戶名]";

	public string InvalidUid => "無效UID參數！";

	public string CreateError => "出現內部錯誤 {0} ";

	public string CreateSuccess => "新賬號 {0} 創建成功!";

	public string DuplicateAccount => "賬號 {0} 已存在!";

	public string DuplicateUID => "UID {0} 已存在!";

	public string DataError => "新賬號獲取失敗! {0}!";
}
