namespace March7thHoney.Internationalization.Message;

public class ServerInfoTextCHT
{
	public string Shutdown => "關閉中…";

	public string CancelKeyPressed => "已按下取消鍵 (Ctrl + C)，服務器即將關閉…";

	public string StartingServer => "正在啟動 March7thHoney…";

	public string CurrentVersion => "當前服務端支持的版本: {0}";

	public string LoadingItem => "正在加載 {0}…";

	public string GeneratingItem => "正在生成 {0}…";

	public string WaitingItem => "正在等待進程 {0} 完成…";

	public string RegisterItem => "註冊了 {0} 個 {1}。";

	public string FailedToLoadItem => "加載 {0} 失敗。";

	public string NewClientSecretKey => "客戶端密鑰不存在，正在生成新的客戶端密鑰。";

	public string FailedToInitializeItem => "初始化 {0} 失敗。";

	public string FailedToReadItem => "讀取 {0} 失敗，文件{1}";

	public string GeneratedItem => "已生成 {0}。";

	public string UpdatedItem => "已更新 {0}。";

	public string LoadedItem => "已加載 {0}。";

	public string LoadedItems => "已加載 {0} 個 {1}。";

	public string ServerRunning => "{0} 服務器正在監聽 {1}";

	public string ServerStarted => "啟動完成！用時 {0}s，輸入 ‘help’ 來獲取命令幫助";

	public string MissionEnabled => "任務系統已啟用，此功能仍在開發中，且可能不會按預期工作，如果遇見任何bug，請彙報給開發者。";

	public string CacheLoadSkip => "已跳過緩存加載。";

	public string ConfigMissing => "{0} 缺失，請檢查你的資源文件夾：{1}，{2} 可能不能使用。";

	public string PartialConfigMissing => "{0} 部分缺失，缺失數量: {1}，示例路徑: {2}";

	public string UnloadedItems => "卸載了所有 {0}。";

	public string SaveDatabase => "已保存數據庫，用時 {0}s";

	public string WaitForAllDone => "現在還不可以進入遊戲，請等待所有項目加載完成後再試";

	public string UnhandledException => "發生未經處理的異常：{0}";

	public string LicenseFileNotFound => "未找到授權檔：{0}";

	public string LicenseInvalid => "授權無效，請前往 {0} 取得授權";

	public string LicenseParseFailed => "授權解析失敗。";

	public string LicenseExpired => "授權已過期。";

	public string LicenseHwidMismatch => "授權 HWID 不匹配。";

	public string LicenseCurrentHwid => "當前機器 HWID：{0}";

	public string LicenseVerified => "授權驗證通過：{0}，到期時間：{1}";

	public string LicenseValidateFailed => "授權驗證失敗。";

	public string PublicModeTrialActive => "授權文件缺失，但當前時間在試用期內，試用期剩餘 {0} 天。";

	public string PublicModeBuildTimeUnavailable => "試用模式不可用。";

	public string PublicModeEnabled => "伺服器為公開版本，正在啟用額外的安全措施。";

	public string PublicModeValidationFailed => "許可證驗證失敗，程序加載已停止。";
}
