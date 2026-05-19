namespace March7thHoney.Internationalization.Message;

public class JsonTextEN
{
	public string Desc => "Import avatar/relic/light cone data from JSON, or clear existing relics and light cones.";

	public string Usage => "Usage: /json\n\nUsage: /json [filename/index/absolute path]\n\nUsage: /json clear\n\nUsage：/json export <name> <格式化(true/false)>";

	public string ClearInventory => "Cleared relics and light cones for the current player.";

	public string FileNotFound => "File not found: {0}";

	public string ReadOrParseFailed => "Failed to read or parse JSON: {0}";

	public string InvalidJsonContent => "JSON content is invalid or empty.";

	public string ImportSummary => "Import finished: {0}, avatars {1}, relics {2}, light cones {3}.";

	public string NoFileFoundWithHint => "No importable JSON files found. Put files in Config/Json first.";

	public string InvalidChoice => "Invalid index. Available range: 1 ~ {0}";

	public string NoFileFound => "No importable JSON files found.";

	public string SearchedDirectories => "Searched directories:";

	public string SearchedDirectoryItem => "- {0}";

	public string FoundFiles => "Found the following JSON files:";

	public string FileListItem => "{0}. {1}";

	public string UsageSelectHint => "Use /json [index] or /json [filename] to import.";

	public string AvatarExcelNotFound => "Avatar config not found: {0}";

	public string ExportSuccess => "Export successful, file: {0}";
}
