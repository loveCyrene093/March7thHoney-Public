namespace March7thHoney.Internationalization.Message;

public class GiveTextEN
{
	public string Desc => "Give items to the player. Avatar IDs can be entered here, but traces, levels, and eidolons cannot be set.";

	public string Usage => "Usage: /give <ItemID> l<Level> x<Count> r<Superimposition>";

	public string ItemNotFound => "Item not found!";

	public string GiveItem => "Gave @{0} {1} of item {2}";
}
