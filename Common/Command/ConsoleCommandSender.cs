using System.Threading.Tasks;
using March7thHoney.Util;

namespace March7thHoney.Command;

public class ConsoleCommandSender(Logger logger) : ICommandSender
{
	public async ValueTask SendMsg(string msg)
	{
		logger.Info(msg);
		await Task.CompletedTask;
	}

	public bool HasPermission(string permission)
	{
		return true;
	}

	public int GetSender()
	{
		return 0;
	}
}
