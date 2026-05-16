using System.Threading.Tasks;

namespace March7thHoney.Command;

public interface ICommandSender
{
	ValueTask SendMsg(string msg);

	bool HasPermission(string permission);

	int GetSender();
}
