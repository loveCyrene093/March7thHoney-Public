namespace March7thHoney.Internationalization.Message;

public class AvatarTextEN
{
	public string Desc => "Set properties for player's owned avatars.\nWhen setting trace level, setting to level X sets all trace nodes to level X. If greater than the node's max allowed level, sets to max level.\nNote: -1 means all owned avatars.";

	public string Usage => "Usage: /avatar talent [AvatarID/-1] [Trace Level]\n\nUsage: /avatar get [AvatarID]\n\nUsage: /avatar rank [AvatarID/-1] [Eidolon]\n\nUsage: /avatar level [AvatarID/-1] [Avatar Level]";

	public string InvalidLevel => "Invalid {0} level";

	public string AllAvatarsLevelSet => "Set all avatars' {0} level to {1}";

	public string AvatarLevelSet => "Set avatar {0}'s {1} level to {2}";

	public string AvatarNotFound => "Avatar does not exist!";

	public string AvatarGet => "Obtained avatar {0}!";

	public string AvatarFailedGet => "Failed to obtain avatar {0}!";
}
