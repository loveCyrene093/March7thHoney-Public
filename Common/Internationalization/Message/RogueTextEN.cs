namespace March7thHoney.Internationalization.Message;

public class RogueTextEN
{
	public string Desc => "Manage player's Simulated Universe data.\n-1 means all blessings (owned blessings).\nUse buff to obtain blessings.\nUse enhance to enhance blessings.";

	public string Usage => "Usage: /rogue money [Cosmic Fragment amount]\n\nUsage: /rogue buff [BlessingID/-1]\n\nUsage: /rogue miracle [CurioID]\n\nUsage: /rogue enhance [BlessingID/-1]\n\nUsage: /rogue unstuck - Leave event";

	public string PlayerGainedMoney => "Player gained {0} Cosmic Fragments";

	public string PlayerGainedAllItems => "Player gained all {0}";

	public string PlayerGainedItem => "Player gained {0} {1}";

	public string PlayerEnhancedBuff => "Player enhanced blessing {0}";

	public string PlayerEnhancedAllBuffs => "Player enhanced all blessings";

	public string PlayerUnstuck => "Player left the event";

	public string NotFoundItem => "{0} not found!";

	public string PlayerNotInRogue => "Player is not in Simulated Universe!";
}
