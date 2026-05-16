using March7thHoney.GameServer.Game.Player;

namespace March7thHoney.GameServer.Game;

public class BasePlayerManager(PlayerInstance player)
{
	public PlayerInstance Player { get; private set; } = player;
}
