namespace March7thHoney.Util;

public static class PluginEventCommon
{
	public delegate void OnConsoleLogHandler(string message);

	public static event OnConsoleLogHandler? OnConsoleLog;

	public static void InvokeOnConsoleLog(string message)
	{
		PluginEventCommon.OnConsoleLog?.Invoke(message);
	}
}
