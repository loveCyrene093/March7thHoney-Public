using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spectre.Console;

namespace March7thHoney.Util;

public static class IConsole
{
	public const string PrefixContent = "March7thHoney > ";

	private const string RedColor = "\u001b[38;2;255;0;0m";

	private const string PinkColor = "\u001b[38;2;235;111;146m";

	private const string ResetColor = "\u001b[0m";

	private static readonly string[] BannerPalette = new string[19]
	{
		"#54C3F7", "#5ABEF2", "#60BAEE", "#67B5EA", "#6DB1E5", "#73ACE1", "#7AA8DD", "#80A3D9", "#869FD4", "#8D9BD0",
		"#9396CC", "#9992C7", "#A08DC3", "#A689BF", "#AC84BB", "#B380B6", "#B97BB2", "#BF77AE", "#C673AA"
	};

	private const int HistoryMaxCount = 10;

	private static readonly List<string> InputHistory = new List<string>();

	private static int HistoryIndex = -1;

	private static readonly object ConsoleSync = new object();

	public static string Prefix
	{
		get
		{
			if (!IsCommandValid)
			{
				return "\u001b[38;2;255;0;0mMarch7thHoney > \u001b[0m";
			}
			return "\u001b[38;2;235;111;146mMarch7thHoney > \u001b[0m";
		}
	}

	public static bool IsCommandValid { get; private set; } = true;

	public static List<char> Input { get; set; } = new List<char>();

	private static int CursorIndex { get; set; }

	public static event Action<string>? OnConsoleExcuteCommand;

	public static void InitConsole()
	{
		Console.Title = "March7thHoney";
		Console.OutputEncoding = Encoding.UTF8;
		PrintBanner();
	}

	public static void PrintBanner()
	{
		AnsiConsole.Write(new Panel(new Markup(BuildGradientMarkup("March7thHoney")))
		{
			Border = BoxBorder.Rounded,
			BorderStyle = new Style(Color.FromHex("#60BAEE")),
			Padding = new Padding(2, 0, 2, 0)
		});
	}

	private static string BuildGradientMarkup(string text)
	{
		char[] array = text.ToCharArray();
		List<string> list = new List<string>(array.Length);
		for (int i = 0; i < array.Length; i++)
		{
			string value = BannerPalette[i % BannerPalette.Length];
			string value2 = Markup.Escape(array[i].ToString());
			list.Add($"[{value}]{value2}[/]");
		}
		return string.Join(string.Empty, list);
	}

	public static int GetWidth(string str)
	{
		return str.Length;
	}

	public static void RedrawInput(List<char> input, bool hasPrefix = true)
	{
		RedrawInput(new string(new ReadOnlySpan<char>(input.ToArray())), hasPrefix);
	}

	public static void RedrawInput(string input, bool hasPrefix = true)
	{
		if (!Console.IsInputRedirected && !Console.IsOutputRedirected)
		{
			UpdateCommandValidity(input);
			int num = GetWidth(input);
			if (hasPrefix)
			{
				input = Prefix + input;
				num += GetWidth("March7thHoney > ");
			}
			if (Console.GetCursorPosition().Left > 0)
			{
				Console.SetCursorPosition(0, Console.CursorTop);
			}
			Console.Write(input + new string(' ', Math.Max(0, Console.BufferWidth - num)));
			Console.SetCursorPosition(num, Console.CursorTop);
			CursorIndex = num - GetWidth("March7thHoney > ");
		}
	}

	public static void WriteExternalLine(Action colorWriter, string plainLine)
	{
		lock (ConsoleSync)
		{
			if (Console.IsOutputRedirected)
			{
				Console.WriteLine(plainLine);
				return;
			}
			string input = new string(new ReadOnlySpan<char>(Input.ToArray()));
			bool num = !Console.IsInputRedirected;
			if (num)
			{
				Console.SetCursorPosition(0, Console.CursorTop);
				Console.Write(new string(' ', Console.BufferWidth));
				Console.SetCursorPosition(0, Console.CursorTop);
			}
			colorWriter();
			if (num)
			{
				RedrawInput(input);
			}
		}
	}

	private static void UpdateCommandValidity(string input)
	{
		IsCommandValid = CheckCommandValid(input);
	}

	public static void HandleEnter()
	{
		string text = new string(new ReadOnlySpan<char>(Input.Where((char ch) => !char.IsControl(ch)).ToArray())).Trim();
		if (text.Length > 256)
		{
			text = text.Substring(0, 256);
		}
		if (!string.IsNullOrWhiteSpace(text))
		{
			Console.WriteLine();
			Input = new List<char>();
			CursorIndex = 0;
			if (InputHistory.Count >= 10)
			{
				InputHistory.RemoveAt(0);
			}
			InputHistory.Add(text);
			HistoryIndex = InputHistory.Count;
			if (text.StartsWith('/'))
			{
				text = text.Substring(1).Trim();
			}
			IConsole.OnConsoleExcuteCommand?.Invoke(text);
			IsCommandValid = true;
		}
	}

	public static void HandleBackspace()
	{
		if (CursorIndex > 0)
		{
			CursorIndex--;
			int width = GetWidth(Input[CursorIndex].ToString());
			Input.RemoveAt(CursorIndex);
			int item = Console.GetCursorPosition().Left;
			Console.SetCursorPosition(item - width, Console.CursorTop);
			Console.Write(new string(new ReadOnlySpan<char>(Input.Skip(CursorIndex).ToArray())) + new string(' ', width));
			Console.SetCursorPosition(item - width, Console.CursorTop);
			bool isCommandValid = IsCommandValid;
			UpdateCommandValidity(new string(new ReadOnlySpan<char>(Input.ToArray())));
			if (IsCommandValid != isCommandValid)
			{
				RedrawInput(Input);
			}
		}
	}

	public static void HandleUpArrow()
	{
		if (InputHistory.Count != 0 && HistoryIndex > 0)
		{
			HistoryIndex--;
			string text = InputHistory[HistoryIndex];
			Input = text.ToList();
			CursorIndex = Input.Count;
			UpdateCommandValidity(text);
			RedrawInput(Input);
		}
	}

	public static void HandleDownArrow()
	{
		if (HistoryIndex < InputHistory.Count)
		{
			HistoryIndex++;
			if (HistoryIndex >= InputHistory.Count)
			{
				HistoryIndex = InputHistory.Count;
				Input = new List<char>();
				CursorIndex = 0;
				IsCommandValid = true;
			}
			else
			{
				string text = InputHistory[HistoryIndex];
				Input = text.ToList();
				CursorIndex = Input.Count;
				UpdateCommandValidity(text);
			}
			RedrawInput(Input);
		}
	}

	public static void HandleLeftArrow()
	{
		if (CursorIndex > 0)
		{
			int item = Console.GetCursorPosition().Left;
			CursorIndex--;
			Console.SetCursorPosition(item - GetWidth(Input[CursorIndex].ToString()), Console.CursorTop);
		}
	}

	public static void HandleRightArrow()
	{
		if (CursorIndex < Input.Count)
		{
			int item = Console.GetCursorPosition().Left;
			CursorIndex++;
			Console.SetCursorPosition(item + GetWidth(Input[CursorIndex - 1].ToString()), Console.CursorTop);
		}
	}

	public static void HandleInput(ConsoleKeyInfo keyInfo)
	{
		if (!char.IsControl(keyInfo.KeyChar) && !char.IsSurrogate(keyInfo.KeyChar) && GetWidth(new string(new ReadOnlySpan<char>(Input.ToArray()))) + GetWidth(keyInfo.KeyChar.ToString()) < Console.BufferWidth - GetWidth("March7thHoney > "))
		{
			HandleInput(keyInfo.KeyChar);
		}
	}

	public static void HandleInput(char keyChar)
	{
		Input.Insert(CursorIndex, keyChar);
		CursorIndex++;
		int num = Console.GetCursorPosition().Left + GetWidth(keyChar.ToString());
		if (num > Console.BufferWidth - 1)
		{
			num = Console.BufferWidth - 1;
		}
		Console.Write(new string(new ReadOnlySpan<char>(Input.Skip(CursorIndex - 1).ToArray())));
		Console.SetCursorPosition(num, Console.CursorTop);
		bool isCommandValid = IsCommandValid;
		UpdateCommandValidity(new string(new ReadOnlySpan<char>(Input.ToArray())));
		if (IsCommandValid != isCommandValid)
		{
			RedrawInput(Input);
		}
	}

	public static string ListenConsole()
	{
		while (true)
		{
			ConsoleKeyInfo keyInfo;
			try
			{
				keyInfo = Console.ReadKey(intercept: true);
			}
			catch (InvalidOperationException)
			{
				continue;
			}
			lock (ConsoleSync)
			{
				switch (keyInfo.Key)
				{
				case ConsoleKey.Enter:
					HandleEnter();
					break;
				case ConsoleKey.Backspace:
					HandleBackspace();
					break;
				case ConsoleKey.LeftArrow:
					HandleLeftArrow();
					break;
				case ConsoleKey.RightArrow:
					HandleRightArrow();
					break;
				case ConsoleKey.UpArrow:
					HandleUpArrow();
					break;
				case ConsoleKey.DownArrow:
					HandleDownArrow();
					break;
				default:
					HandleInput(keyInfo);
					break;
				}
			}
		}
	}

	private static bool CheckCommandValid(string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			return true;
		}
		return !new char[6] { '@', '#', '$', '%', '&', '*' }.Any((char c) => input.Contains(c));
	}
}
