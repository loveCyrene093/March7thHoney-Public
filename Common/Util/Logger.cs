using System;
using System.Diagnostics;
using System.IO;
using March7thHoney.Internationalization;
using Spectre.Console;

namespace March7thHoney.Util;

public class Logger(string moduleName)
{
	private static FileInfo? _logFile;

	private static FileInfo? _debugLogFile;

	private static readonly object Lock = new object();

	public void Log(string message, LoggerLevel level)
	{
		lock (Lock)
		{
			string value = DateTime.Now.ToString("HH:mm:ss");
			string value2 = Markup.Escape(message);
			string value3 = Markup.Escape(moduleName);
			string value4 = level switch
			{
				LoggerLevel.INFO => "#7AA8DD", 
				LoggerLevel.WARN => "#F6C177", 
				LoggerLevel.ERROR => "#EB6F92", 
				LoggerLevel.FATAL => "#C73E1D", 
				LoggerLevel.DEBUG => "#9CCFD8", 
				_ => "#9992C7", 
			};
			try
			{
				if (!Console.IsOutputRedirected)
				{
					string colored = $"[grey70][[{value}]][/] [#60BAEE][[{value3}]][/] [{value4}]{level}[/] {value2}";
					IConsole.WriteExternalLine(plainLine: $"[{value}] [{moduleName}] {level} {message}", colorWriter: delegate
					{
						AnsiConsole.MarkupLine(colored);
					});
				}
				else
				{
					Console.WriteLine($"[{value}][{moduleName}] {message}");
				}
			}
			catch
			{
				Console.WriteLine($"[{value}][{moduleName}] {message}");
			}
			string message2 = $"[{value}][{moduleName}][{level}] {message}";
			PluginEventCommon.InvokeOnConsoleLog(message2);
			if (level == LoggerLevel.DEBUG)
			{
				WriteToDebugFile(message2);
			}
			else
			{
				WriteToFile(message2);
			}
		}
	}

	public void Info(string message, Exception? e = null)
	{
		Log(message, LoggerLevel.INFO);
		if (e != null)
		{
			Log(e.Message, LoggerLevel.INFO);
			Log(e.StackTrace ?? string.Empty, LoggerLevel.INFO);
		}
	}

	public void InfoI18n(string key, params string[] args)
	{
		Info(I18NManager.Translate(key, args));
	}

	public void Warn(string message, Exception? e = null)
	{
		Log(message, LoggerLevel.WARN);
		if (e != null)
		{
			Log(e.Message, LoggerLevel.WARN);
			Log(e.StackTrace ?? string.Empty, LoggerLevel.WARN);
		}
	}

	public void WarnI18n(string key, params string[] args)
	{
		Warn(I18NManager.Translate(key, args));
	}

	public void Error(string message, Exception? e = null)
	{
		Log(message, LoggerLevel.ERROR);
		if (e != null)
		{
			Log(e.Message, LoggerLevel.ERROR);
			Log(e.StackTrace ?? string.Empty, LoggerLevel.ERROR);
		}
	}

	public void ErrorI18n(string key, params string[] args)
	{
		Error(I18NManager.Translate(key, args));
	}

	public void Fatal(string message, Exception? e = null)
	{
		Log(message, LoggerLevel.FATAL);
		if (e != null)
		{
			Log(e.Message, LoggerLevel.FATAL);
			Log(e.StackTrace ?? string.Empty, LoggerLevel.FATAL);
		}
	}

	public void Debug(string message, Exception? e = null)
	{
		Log(message, LoggerLevel.DEBUG);
		if (e != null)
		{
			Log(e.Message, LoggerLevel.DEBUG);
			Log(e.StackTrace ?? string.Empty, LoggerLevel.DEBUG);
		}
	}

	public static void SetLogFile(FileInfo file)
	{
		_logFile = file;
	}

	public static void SetDebugLogFile(FileInfo file)
	{
		_debugLogFile = file;
	}

	public static void WriteToFile(string message)
	{
		try
		{
			if (_logFile == null)
			{
				throw new Exception("LogFile is not set");
			}
			_logFile.Directory?.Create();
			using StreamWriter streamWriter = _logFile.AppendText();
			streamWriter.WriteLine(message);
		}
		catch
		{
		}
	}

	public static void WriteToDebugFile(string message)
	{
		try
		{
			if (_debugLogFile == null)
			{
				throw new Exception("DebugLogFile is not set");
			}
			_debugLogFile.Directory?.Create();
			using StreamWriter streamWriter = _debugLogFile.AppendText();
			streamWriter.WriteLine(message);
		}
		catch
		{
		}
	}

	public static Logger GetByClassName()
	{
		return new Logger(new StackTrace().GetFrame(1)?.GetMethod()?.ReflectedType?.Name ?? string.Empty);
	}
}
