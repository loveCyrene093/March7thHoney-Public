namespace March7thHoney.GameServer.Game.Activity;

public class BaseActivityInstance
{
	public ActivityManager ActivityManager { get; private set; }

	public BaseActivityInstance(ActivityManager manager)
	{
		ActivityManager = manager;
		base._002Ector();
	}
}
