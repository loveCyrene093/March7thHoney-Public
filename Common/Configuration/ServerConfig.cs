using System.Collections.Generic;

namespace March7thHoney.Configuration;

public class ServerConfig
{
	public bool RunDispatch { get; set; } = true;

	public string FromDispatchBaseUrl { get; set; } = "";

	public bool RunGateway { get; set; } = true;

	public List<ServerRegion> Regions { get; set; } = new List<ServerRegion>();
}
