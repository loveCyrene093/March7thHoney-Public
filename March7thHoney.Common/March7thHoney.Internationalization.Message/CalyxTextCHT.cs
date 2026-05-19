namespace March7thHoney.Internationalization.Message;

public class CalyxTextCHT
{
	public string Desc => "切換花萼覆蓋模式：開啟時將擬造花萼替換為 freesr 文件中的關卡內容。";

	public string Usage => "用法：/calyx on\n用法：/calyx off";

	public string ToggleOn => "花萼覆蓋已開啟。";

	public string ToggleOff => "花萼覆蓋已關閉。";

	public string MissingIndex => "請指定 freesr 文件序號。用法：/calyx on [序號]";

	public string InvalidMode => "未知模式 '{0}'。請使用 /calyx on 或 /calyx off。";

	public string LoadFailed => "加載 freesr 文件失敗。";

	public string NoCachedData => "未找到已緩存的 freesr 數據。請先使用 /json <檔名> 或通過 srtools 網站同步導入。";
}
