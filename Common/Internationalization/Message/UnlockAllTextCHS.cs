namespace March7thHoney.Internationalization.Message;

public class UnlockAllTextCHS
{
	public string Desc => "解锁所有在类别内的对象\n使用 /unlockall mission 以完成所有任务，使用后会被踢出，重新登录后可能会被教程卡住，请谨慎使用\n使用 /unlockall tutorial 以解锁所有教程，使用后会被踢出，用于部分界面卡住无法行动的情况\n使用 /unlockall rogue 以解锁所有类型模拟宇宙，使用后会被踢出，建议与 /unlockall tutorial 搭配使用以获取更好效果";

	public string Usage => "用法：/unlockall [mission/tutorial/rogue]";

	public string UnlockedAll => "已解锁/完成所有{0}!";
}
