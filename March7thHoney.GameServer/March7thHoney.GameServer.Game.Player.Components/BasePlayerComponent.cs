namespace March7thHoney.GameServer.Game.Player.Components;

public abstract class BasePlayerComponent
{
	protected PlayerInstance Player { get; }

	protected BasePlayerComponent(PlayerInstance player)
	{
		Player = player;
		base._002Ector();
	}
}
