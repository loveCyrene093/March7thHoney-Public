namespace March7thHoney.Internationalization.Message;

public class UnlockAllTextEN
{
	public string Desc => "Unlock all objects within the category.\nUse /unlockall mission to complete all missions. You will be kicked after use, and may get stuck in the tutorial upon re-login. Use with caution.\nUse /unlockall tutorial to unlock all tutorials. You will be kicked after use. Use for situations where the interface is stuck and you cannot act.\nUse /unlockall rogue to unlock all types of Simulated Universe. You will be kicked after use. Recommended to use with /unlockall tutorial for better results.";

	public string Usage => "Usage: /unlockall [mission/tutorial/rogue]";

	public string UnlockedAll => "Unlocked/completed all {0}!";
}
