using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace March7thHoney.Util.License;

public static class HardwareIdManager
{
	public static string GetHwid()
	{
		InlineArray4<string> buffer = default(InlineArray4<string>);
		buffer[0] = GetMachineGuid();
		buffer[1] = Environment.MachineName;
		buffer[2] = Environment.UserDomainName;
		buffer[3] = Environment.OSVersion.VersionString;
		string s = string.Join("|", (ReadOnlySpan<string?>)buffer);
		return Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(s)));
	}

	private static string GetMachineGuid()
	{
		if (OperatingSystem.IsWindows())
		{
			return GetMachineGuidWindows();
		}
		if (OperatingSystem.IsLinux())
		{
			return GetMachineGuidLinux();
		}
		if (OperatingSystem.IsMacOS())
		{
			return GetMachineGuidMacOs();
		}
		return "unknown-guid";
	}

	[SupportedOSPlatform("windows")]
	private static string GetMachineGuidWindows()
	{
		try
		{
			string text = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography")?.GetValue("MachineGuid")?.ToString();
			return string.IsNullOrWhiteSpace(text) ? "unknown-guid" : text.Trim();
		}
		catch
		{
			return "unknown-guid";
		}
	}

	private static string GetMachineGuidLinux()
	{
		string[] array = new string[2] { "/etc/machine-id", "/var/lib/dbus/machine-id" };
		foreach (string path in array)
		{
			try
			{
				if (File.Exists(path))
				{
					string text = File.ReadAllText(path).Trim();
					if (!string.IsNullOrWhiteSpace(text))
					{
						return text;
					}
				}
			}
			catch
			{
			}
		}
		return "unknown-guid";
	}

	private static string GetMachineGuidMacOs()
	{
		try
		{
			using Process process = Process.Start(new ProcessStartInfo
			{
				FileName = "/usr/sbin/ioreg",
				Arguments = "-rd1 -c IOPlatformExpertDevice",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			});
			if (process == null)
			{
				return "unknown-guid";
			}
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit(2000);
			string text2 = "IOPlatformUUID";
			int num = text.IndexOf(text2, StringComparison.Ordinal);
			if (num < 0)
			{
				return "unknown-guid";
			}
			int num2 = text.IndexOf('"', num + text2.Length);
			if (num2 < 0)
			{
				return "unknown-guid";
			}
			int num3 = text.IndexOf('"', num2 + 1);
			if (num3 < 0)
			{
				return "unknown-guid";
			}
			string text3 = text.Substring(num2 + 1, num3 - num2 - 1).Trim();
			return string.IsNullOrWhiteSpace(text3) ? "unknown-guid" : text3;
		}
		catch
		{
			return "unknown-guid";
		}
	}
}
