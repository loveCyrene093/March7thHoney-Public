using System.Linq;
using March7thHoney.Kcp;

namespace March7thHoney.GameServer.Server;

public class Listener : March7thHoneyListener
{
	public static Connection? GetActiveConnection(int uid)
	{
		return March7thHoneyListener.Connections.Values.FirstOrDefault(delegate(March7thHoneyConnection c)
		{
			Connection obj = c as Connection;
			return obj != null && obj.Player?.Uid == uid && c.State == SessionStateEnum.ACTIVE;
		}) as Connection;
	}
}
