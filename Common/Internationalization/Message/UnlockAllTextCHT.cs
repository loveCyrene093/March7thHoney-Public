namespace March7thHoney.Internationalization.Message;

public class UnlockAllTextCHT
{
	public string Desc => "解鎖所有在類別內的對象\n使用 /unlockall mission 以完成所有任務，使用後會被踢出，重新登錄後可能會被教程卡住，請謹慎使用\n使用 /unlockall tutorial 以解鎖所有教程，使用後會被踢出，用於部分界面卡住無法行動的情況\n使用 /unlockall rogue 以解鎖所有類型模擬宇宙，使用後會被踢出，建議與 /unlockall tutorial 搭配使用以獲取更好效果";

	public string Usage => "用法：/unlockall [mission/tutorial/rogue]";

	public string UnlockedAll => "已解鎖/完成所有{0}!";
}
