namespace March7thHoney.Internationalization.Message;

public class CalyxTextEN
{
	public string Desc => "Toggle calyx override mode that replaces calyx battles with freesr file content.";

	public string Usage => "Usage: /calyx on\nUsage: /calyx off";

	public string ToggleOn => "Calyx override is ON.";

	public string ToggleOff => "Calyx override is OFF.";

	public string MissingIndex => "Please provide a freesr file index. Usage: /calyx on [index]";

	public string InvalidMode => "Unknown mode '{0}'. Use /calyx on or /calyx off.";

	public string LoadFailed => "Failed to load freesr file.";

	public string NoCachedData => "No cached freesr data. Run /json <file> or sync via srtools first.";
}
