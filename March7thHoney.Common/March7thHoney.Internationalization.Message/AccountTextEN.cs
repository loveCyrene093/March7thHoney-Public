namespace March7thHoney.Internationalization.Message;

public class AccountTextEN
{
	public string Desc => "Create an account.\nNote: This command is untested. Use with caution!";

	public string Usage => "Usage: /account create [Username]";

	public string InvalidUid => "Invalid UID parameter!";

	public string CreateError => "Internal error occurred {0} ";

	public string CreateSuccess => "New account {0} created successfully!";

	public string DuplicateAccount => "Account {0} already exists!";

	public string DuplicateUID => "UID {0} already exists!";

	public string DataError => "Failed to get new account data! {0}!";
}
