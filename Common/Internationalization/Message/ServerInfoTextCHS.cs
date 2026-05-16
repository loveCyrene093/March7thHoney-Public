namespace March7thHoney.Internationalization.Message;

public class ServerInfoTextCHS
{
	public string Shutdown => "关闭中…";

	public string CancelKeyPressed => "已按下取消键 (Ctrl + C)，服务器即将关闭…";

	public string StartingServer => "正在启动 March7thHoney…";

	public string CurrentVersion => "当前服务端支持的版本: {0}";

	public string LoadingItem => "正在加载 {0}…";

	public string GeneratingItem => "正在生成 {0}…";

	public string WaitingItem => "正在等待进程 {0} 完成…";

	public string RegisterItem => "注册了 {0} 个 {1}。";

	public string FailedToLoadItem => "加载 {0} 失败。";

	public string NewClientSecretKey => "客户端密钥不存在，正在生成新的客户端密钥。";

	public string FailedToInitializeItem => "初始化 {0} 失败。";

	public string FailedToReadItem => "读取 {0} 失败，文件{1}";

	public string GeneratedItem => "已生成 {0}。";

	public string UpdatedItem => "已更新 {0}。";

	public string LoadedItem => "已加载 {0}。";

	public string LoadedItems => "已加载 {0} 个 {1}。";

	public string ServerRunning => "{0} 服务器正在监听 {1}";

	public string ServerStarted => "启动完成！用时 {0}s，输入 ‘help’ 来获取命令帮助";

	public string MissionEnabled => "任务系统已启用，此功能仍在开发中，且可能不会按预期工作，如果遇见任何bug，请汇报给开发者。";

	public string CacheLoadSkip => "已跳过缓存加载。";

	public string ConfigMissing => "{0} 缺失，请检查你的资源文件夹：{1}，{2} 可能不能使用。";

	public string PartialConfigMissing => "{0} 部分缺失，缺失数量: {1}，示例路径: {2}";

	public string UnloadedItems => "卸载了所有 {0}。";

	public string SaveDatabase => "已保存数据库，用时 {0}s";

	public string WaitForAllDone => "现在还不可以进入游戏，请等待所有项目加载完成后再试";

	public string UnhandledException => "发生未经处理的异常：{0}";

	public string LicenseFileNotFound => "未找到许可证文件：{0}";

	public string LicenseInvalid => "许可证无效，请前往 {0} 获取授权";

	public string LicenseParseFailed => "许可证解析失败。";

	public string LicenseExpired => "许可证已过期。";

	public string LicenseHwidMismatch => "许可证 HWID 不匹配。";

	public string LicenseCurrentHwid => "当前机器 HWID：{0}";

	public string LicenseVerified => "许可证校验通过：{0}，过期时间：{1}";

	public string LicenseValidateFailed => "许可证校验失败。";

	public string PublicModeTrialActive => "授权文件缺失，但当前时间在试用期内，试用期剩余 {0} 天。";

	public string PublicModeBuildTimeUnavailable => "试用模式不可用。";

	public string PublicModeEnabled => "服务器为公开版本，正在启用额外的安全措施。";

	public string PublicModeValidationFailed => "许可证验证失败，程序加载已停止。";
}
