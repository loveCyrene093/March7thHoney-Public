using March7thHoney.Command;

namespace March7thHoney.GameServer.Command;

public static class CommandExecutor
{
	public delegate void RunCommand(ICommandSender sender, string cmd);

	public static event RunCommand? OnRunCommand;

	public static void ExecuteCommand(ICommandSender sender, string cmd)
	{
		CommandExecutor.OnRunCommand?.Invoke(sender, cmd);
	}
}
