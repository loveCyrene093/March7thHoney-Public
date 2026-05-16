using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using March7thHoney.GameServer.Plugin.Event;
using March7thHoney.GameServer.Server;
using March7thHoney.Internationalization;
using March7thHoney.Kcp;
using March7thHoney.Util;
using Spectre.Console;

namespace March7thHoney.Command.Command;

public class CommandManager
{
	private const int MaxCommandHistory = 100;

	private readonly List<string> _commandHistory = new List<string>();

	private int _historyIndex = -1;

	public static CommandManager? Instance { get; private set; }

	public Dictionary<string, ICommand> Commands { get; } = new Dictionary<string, ICommand>();

	public Dictionary<string, CommandInfoAttribute> CommandInfo { get; } = new Dictionary<string, CommandInfoAttribute>();

	public Dictionary<string, string> CommandAlias { get; } = new Dictionary<string, string>();

	public Logger Logger { get; } = new Logger("CommandManager");

	public Connection? Target { get; set; }

	public void RegisterCommands()
	{
		Instance = this;
		Type[] types = Assembly.GetExecutingAssembly().GetTypes();
		foreach (Type type in types)
		{
			if (typeof(ICommand).IsAssignableFrom(type) && !type.IsAbstract)
			{
				RegisterCommand(type);
			}
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.RegisterItem", Commands.Count.ToString(), I18NManager.Translate("Word.Command")));
	}

	public void RegisterCommand(Type type)
	{
		CommandInfoAttribute customAttribute = type.GetCustomAttribute<CommandInfoAttribute>();
		if (customAttribute != null && Activator.CreateInstance(type) is ICommand value)
		{
			Commands.Add(customAttribute.Name, value);
			CommandInfo.Add(customAttribute.Name, customAttribute);
			string[] alias = customAttribute.Alias;
			foreach (string key in alias)
			{
				CommandAlias.Add(key, customAttribute.Name);
			}
		}
	}

	public void Start()
	{
		while (true)
		{
			try
			{
				string text = ReadCommand();
				if (!string.IsNullOrEmpty(text))
				{
					if (text.StartsWith("/"))
					{
						text = text.Substring(1);
					}
					if (_commandHistory.Count >= 100)
					{
						_commandHistory.RemoveAt(0);
					}
					if (_commandHistory.Count == 0 || _commandHistory.Last() != text)
					{
						_commandHistory.Add(text);
					}
					_historyIndex = _commandHistory.Count;
					HandleCommand(text, new ConsoleCommandSender(Logger));
				}
			}
			catch
			{
				Logger.Error(I18NManager.Translate("Game.Command.Notice.InternalError"));
			}
		}
	}

	private string ReadCommand()
	{
		List<char> list = new List<char>();
		AnsiConsole.Markup("[yellow]> [/]");
		while (true)
		{
			ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(intercept: true);
			if (consoleKeyInfo.Key == ConsoleKey.Enter)
			{
				break;
			}
			switch (consoleKeyInfo.Key)
			{
			case ConsoleKey.Backspace:
				if (list.Count > 0)
				{
					list.RemoveAt(list.Count - 1);
					Console.Write("\b \b");
				}
				break;
			case ConsoleKey.UpArrow:
				if (_historyIndex > 0)
				{
					_historyIndex--;
					ReplaceInput(list, _commandHistory[_historyIndex]);
				}
				break;
			case ConsoleKey.DownArrow:
				if (_historyIndex < _commandHistory.Count - 1)
				{
					_historyIndex++;
					ReplaceInput(list, _commandHistory[_historyIndex]);
				}
				else if (_historyIndex == _commandHistory.Count - 1)
				{
					_historyIndex++;
					ReplaceInput(list, string.Empty);
				}
				break;
			default:
				list.Add(consoleKeyInfo.KeyChar);
				Console.Write(consoleKeyInfo.KeyChar);
				break;
			}
		}
		Console.WriteLine();
		return new string(list.ToArray());
	}

	private static void ReplaceInput(List<char> input, string newText)
	{
		while (input.Count > 0)
		{
			input.RemoveAt(input.Count - 1);
			Console.Write("\b \b");
		}
		input.AddRange(newText.ToCharArray());
		Console.Write(newText);
	}

	public void HandleCommand(string input, ICommandSender sender)
	{
		try
		{
			string text = input.Split(' ')[0];
			Connection connection = Target;
			if (sender is ConsoleCommandSender)
			{
				if (text.StartsWith('@'))
				{
					string target = text.Substring(1);
					if (March7thHoneyListener.Connections.Values.ToList().Find((March7thHoneyConnection item) => (item as Connection)?.Player?.Uid.ToString() == target) is Connection connection2)
					{
						Target = connection2;
						sender.SendMsg(I18NManager.Translate("Game.Command.Notice.TargetFound", target, connection2.Player.Data.Name));
					}
					else
					{
						sender.SendMsg(I18NManager.Translate("Game.Command.Notice.TargetNotFound", target));
					}
					return;
				}
			}
			else
			{
				PluginEvent.InvokeOnPlayerUseCommand(sender, input);
				connection = Listener.GetActiveConnection(sender.GetSender());
				if (connection == null)
				{
					sender.SendMsg(I18NManager.Translate("Game.Command.Notice.TargetNotFound", sender.GetSender().ToString()));
					return;
				}
			}
			if (connection != null && !connection.IsOnline)
			{
				sender.SendMsg(I18NManager.Translate("Game.Command.Notice.TargetOffline", connection.Player.Uid.ToString(), connection.Player.Data.Name));
				connection = null;
			}
			if (CommandAlias.TryGetValue(text, out string value))
			{
				text = value;
			}
			if (Commands.TryGetValue(text, out ICommand value2))
			{
				List<string> list = input.Split(' ').ToList();
				list.RemoveAt(0);
				CommandArg commandArg = new CommandArg(list.JoinFormat(" ", ""), sender, connection);
				if (commandArg.Target?.Player?.Uid != sender.GetSender() && !sender.HasPermission("command.others"))
				{
					sender.SendMsg(I18NManager.Translate("Game.Command.Notice.NoPermission"));
					return;
				}
				bool flag = false;
				CommandInfoAttribute commandInfoAttribute = CommandInfo[text];
				if (!sender.HasPermission(commandInfoAttribute.Permission))
				{
					sender.SendMsg(I18NManager.Translate("Game.Command.Notice.NoPermission"));
					return;
				}
				MethodInfo[] methods = value2.GetType().GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					CommandMethodAttribute customAttribute = methodInfo.GetCustomAttribute<CommandMethodAttribute>();
					if (customAttribute == null)
					{
						continue;
					}
					bool flag2 = true;
					foreach (CommandCondition condition in customAttribute.Conditions)
					{
						if (list.Count <= condition.Index)
						{
							flag2 = false;
							break;
						}
						if (!list[condition.Index].Equals(condition.ShouldBe))
						{
							flag2 = false;
							break;
						}
					}
					if (flag2)
					{
						flag = true;
						methodInfo.Invoke(value2, new object[1] { commandArg });
						break;
					}
				}
				if (flag)
				{
					return;
				}
				methods = value2.GetType().GetMethods();
				foreach (MethodInfo methodInfo2 in methods)
				{
					if (methodInfo2.GetCustomAttribute<CommandDefaultAttribute>() != null)
					{
						flag = true;
						methodInfo2.Invoke(value2, new object[1] { commandArg });
						break;
					}
				}
				if (!flag)
				{
					sender.SendMsg(I18NManager.Translate(commandInfoAttribute.Usage));
				}
			}
			else
			{
				sender.SendMsg(I18NManager.Translate("Game.Command.Notice.CommandNotFound"));
			}
		}
		catch (Exception e)
		{
			Logger.Error(I18NManager.Translate("Game.Command.Notice.InternalError"), e);
			sender.SendMsg(I18NManager.Translate("Game.Command.Notice.InternalError"));
		}
	}
}
