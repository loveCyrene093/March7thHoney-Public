using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using March7thHoney.Internationalization;
using Newtonsoft.Json;

namespace March7thHoney.Util.License;

public static class LicenseManager
{
	private static readonly Logger Logger = new Logger("License");

	private const string LicensePath = "Config/March7thHoney.license";

	private const string HelpUrl = "discord.gg/castoriceps";

	private const string BuildUtcMetadataKey = "BuildUtc";

	public static bool ValidateInPublicMode()
	{
		try
		{
			string hwid = HardwareIdManager.GetHwid();
			Logger.Info(I18NManager.Translate("Server.ServerInfo.LicenseCurrentHwid", hwid));
			if (!File.Exists("Config/March7thHoney.license"))
			{
				if (IsWithinBuildTrialWindow())
				{
					Logger.Warn(I18NManager.Translate("Server.ServerInfo.PublicModeTrialActive", 30.ToString()));
					return true;
				}
				Logger.Error(I18NManager.Translate("Server.ServerInfo.LicenseFileNotFound", "Config/March7thHoney.license"));
				Logger.Error(I18NManager.Translate("Server.ServerInfo.LicenseInvalid", "discord.gg/castoriceps"));
				return false;
			}
			LicenseInfo licenseInfo = JsonConvert.DeserializeObject<LicenseInfo>(LicenseCryptoManager.Decrypt(File.ReadAllText("Config/March7thHoney.license")));
			if (licenseInfo == null)
			{
				Logger.Error(I18NManager.Translate("Server.ServerInfo.LicenseParseFailed"));
				Logger.Error(I18NManager.Translate("Server.ServerInfo.LicenseInvalid", "discord.gg/castoriceps"));
				return false;
			}
			long num = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			if (licenseInfo.ExpireAt <= num)
			{
				Logger.Error(I18NManager.Translate("Server.ServerInfo.LicenseExpired"));
				Logger.Error(I18NManager.Translate("Server.ServerInfo.LicenseInvalid", "discord.gg/castoriceps"));
				return false;
			}
			if (!string.Equals(licenseInfo.Hwid?.Trim(), hwid, StringComparison.OrdinalIgnoreCase))
			{
				Logger.Error(I18NManager.Translate("Server.ServerInfo.LicenseHwidMismatch"));
				Logger.Error(I18NManager.Translate("Server.ServerInfo.LicenseInvalid", "discord.gg/castoriceps"));
				return false;
			}
			DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(licenseInfo.ExpireAt).ToLocalTime();
			Logger.Info(I18NManager.Translate("Server.ServerInfo.LicenseVerified", licenseInfo.Holder, dateTimeOffset.ToString("yyyy-MM-dd HH:mm:ss")));
			return true;
		}
		catch (Exception e)
		{
			Logger.Error(I18NManager.Translate("Server.ServerInfo.LicenseValidateFailed"), e);
			Logger.Error(I18NManager.Translate("Server.ServerInfo.LicenseInvalid", "discord.gg/castoriceps"));
			return false;
		}
	}

	private static bool IsWithinBuildTrialWindow()
	{
		DateTime? compileTimeUtcFromEntryAssembly = GetCompileTimeUtcFromEntryAssembly();
		if (!compileTimeUtcFromEntryAssembly.HasValue)
		{
			Logger.Warn(I18NManager.Translate("Server.ServerInfo.PublicModeBuildTimeUnavailable"));
			return false;
		}
		DateTime dateTime = compileTimeUtcFromEntryAssembly.Value.AddDays(30.0);
		return DateTime.UtcNow <= dateTime;
	}

	private static DateTime? GetCompileTimeUtcFromEntryAssembly()
	{
		foreach (Assembly item in new Assembly[2]
		{
			Assembly.GetEntryAssembly(),
			Assembly.GetExecutingAssembly()
		}.Where((Assembly x) => x != null))
		{
			string text = item.GetCustomAttributes<AssemblyMetadataAttribute>().FirstOrDefault((AssemblyMetadataAttribute x) => x.Key == "BuildUtc")?.Value;
			if (!string.IsNullOrWhiteSpace(text) && DateTime.TryParseExact(text, "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out var result))
			{
				return result;
			}
		}
		return null;
	}
}
