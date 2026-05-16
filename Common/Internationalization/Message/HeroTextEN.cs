namespace March7thHoney.Internationalization.Message;

public class HeroTextEN
{
	public string Desc => "Switch the main character's gender/form.\nWhen switching gender, genderId 1 represents male, 2 represents female.\nWhen switching form, 8001 represents Destruction Path, 8003 represents Preservation Path, 8005 represents Harmony Path.\nNote: Switching gender will clear all optional Paths and Traces, and this operation is irreversible!";

	public string Usage => "Usage: /hero gender [genderId]\n\nUsage: /hero type [typeId]";

	public string GenderNotSpecified => "Gender does not exist!";

	public string HeroTypeNotSpecified => "Hero type does not exist!";

	public string GenderChanged => "Gender changed!";

	public string HeroTypeChanged => "Hero type changed!";
}
