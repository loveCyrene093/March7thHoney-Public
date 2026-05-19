using System.Threading.Tasks;
using March7thHoney.Util;

namespace March7thHoney.Command;

public class ConsoleCommandSender : ICommandSender
{
	public ConsoleCommandSender(Logger logger)
	{
		_003Clogger_003EP = logger;
		base._002Ector();
	}

	public async ValueTask SendMsg(string msg)
	{
		_003Clogger_003EP.Info(msg);
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
