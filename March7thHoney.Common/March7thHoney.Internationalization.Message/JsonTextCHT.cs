namespace March7thHoney.Internationalization.Message;

public class JsonTextCHT
{
	public string Desc => "從 JSON 導入角色、遺器、光錐數據，或清空現有遺器和光錐。";

	public string Usage => "用法：/json\n\n用法：/json [文件名/序號/絕對路徑]\n\n用法：/json clear\n\n用法：/json export <name> <格式化(true/false)>";

	public string ClearInventory => "已清空當前玩家的遺器和光錐。";

	public string FileNotFound => "未找到文件：{0}";

	public string ReadOrParseFailed => "讀取或解析 JSON 失敗：{0}";

	public string InvalidJsonContent => "JSON 內容無效或為空。";

	public string ImportSummary => "導入完成：{0}，角色 {1}，遺器 {2}，光錐 {3}。";

	public string NoFileFoundWithHint => "未找到可導入的 JSON 文件，請先將文件放到 Config/Json。";

	public string InvalidChoice => "無效序號，可選範圍：1 ~ {0}";

	public string NoFileFound => "未找到可導入的 JSON 文件。";

	public string SearchedDirectories => "已搜索目錄：";

	public string SearchedDirectoryItem => "- {0}";

	public string FoundFiles => "找到以下 JSON 文件：";

	public string FileListItem => "{0}. {1}";

	public string UsageSelectHint => "輸入 /json [序號] 或 /json [文件名] 進行導入。";

	public string AvatarExcelNotFound => "未找到角色配置：{0}";

	public string ExportSuccess => "匯出成功，檔案：{0}";
}
