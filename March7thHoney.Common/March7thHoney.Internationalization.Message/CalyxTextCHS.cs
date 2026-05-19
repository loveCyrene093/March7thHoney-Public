namespace March7thHoney.Internationalization.Message;

public class CalyxTextCHS
{
	public string Desc => "切换花萼覆盖模式：开启时将拟造花萼替换为 freesr 文件中的关卡内容。";

	public string Usage => "用法：/calyx on\n用法：/calyx off";

	public string ToggleOn => "花萼覆盖已开启。";

	public string ToggleOff => "花萼覆盖已关闭。";

	public string MissingIndex => "请指定 freesr 文件序号。用法：/calyx on [序号]";

	public string InvalidMode => "未知模式 '{0}'。请使用 /calyx on 或 /calyx off。";

	public string LoadFailed => "加载 freesr 文件失败。";

	public string NoCachedData => "未找到已缓存的 freesr 数据。请先使用 /json <文件名> 或通过 srtools 网站同步导入。";
}
