using System.Threading.Tasks;

namespace March7thHoney.GameServer.Server.Packet;

public abstract class Handler
{
	public abstract Task OnHandle(Connection connection, byte[] header, byte[] data);
}
