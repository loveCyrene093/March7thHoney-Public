using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game;

public class BasePlayerManager
{
	public PlayerInstance Player { get; private set; }

	public BasePlayerManager(PlayerInstance player)
	{
		Player = player;
		base._002Ector();
	}
}
