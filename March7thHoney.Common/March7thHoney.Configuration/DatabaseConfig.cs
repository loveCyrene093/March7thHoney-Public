namespace March7thHoney.Configuration;

public class DatabaseConfig
{
	public string DatabaseType { get; set; } = "sqlite";

	public string DatabaseName { get; set; } = "March7thHoney.db";

	public string MySqlHost { get; set; } = "127.0.0.1";

	public int MySqlPort { get; set; } = 3306;

	public string MySqlUser { get; set; } = "root";

	public string MySqlPassword { get; set; } = "123456";

	public string MySqlDatabase { get; set; } = "March7thHoney";
}
