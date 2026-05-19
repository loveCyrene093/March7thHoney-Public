namespace March7thHoney.Internationalization.Message;

public class JsonTextCHS
{
	public string Desc => "从 JSON 导入角色、遗器、光锥数据，或清空现有遗器和光锥。";

	public string Usage => "用法：/json\n\n用法：/json [文件名/序号/绝对路径]\n\n用法：/json clear\n\n用法：/json export <name> <格式化(true/false)>";

	public string ClearInventory => "已清空当前玩家的遗器和光锥。";

	public string FileNotFound => "未找到文件：{0}";

	public string ReadOrParseFailed => "读取或解析 JSON 失败：{0}";

	public string InvalidJsonContent => "JSON 内容无效或为空。";

	public string ImportSummary => "导入完成：{0}，角色 {1}，遗器 {2}，光锥 {3}。";

	public string NoFileFoundWithHint => "未找到可导入的 JSON 文件，请先将文件放到 Config/Json。";

	public string InvalidChoice => "无效序号，可选范围：1 ~ {0}";

	public string NoFileFound => "未找到可导入的 JSON 文件。";

	public string SearchedDirectories => "已搜索目录：";

	public string SearchedDirectoryItem => "- {0}";

	public string FoundFiles => "找到以下 JSON 文件：";

	public string FileListItem => "{0}. {1}";

	public string UsageSelectHint => "输入 /json [序号] 或 /json [文件名] 进行导入。";

	public string AvatarExcelNotFound => "未找到角色配置：{0}";

	public string ExportSuccess => "导出成功，文件：{0}";
}
