namespace March7thHoney.Configuration;

public class ConfigContainer
{
	public HttpServerConfig HttpServer { get; set; } = new HttpServerConfig();

	public KeyStoreConfig KeyStore { get; set; } = new KeyStoreConfig();

	public GameServerConfig GameServer { get; set; } = new GameServerConfig();

	public PathConfig Path { get; set; } = new PathConfig();

	public DatabaseConfig Database { get; set; } = new DatabaseConfig();

	public ServerOption ServerOption { get; set; } = new ServerOption();

	public MuipServerConfig MuipServer { get; set; } = new MuipServerConfig();

	public WebSecurityConfig WebSecurity { get; set; } = new WebSecurityConfig();
}
