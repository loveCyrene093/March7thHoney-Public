using System;
using System.Globalization;

namespace March7thHoney.Util;

public static class ServerTimeProvider
{
	public static long GetServerUnixSec()
	{
		if (!ConfigManager.Config.ServerOption.ServerTime.EnableFakeServerTime)
		{
			return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		}
		return new DateTimeOffset(GetFixedLocalDate()).ToUnixTimeSeconds();
	}

	public static long GetServerUnixMs()
	{
		if (!ConfigManager.Config.ServerOption.ServerTime.EnableFakeServerTime)
		{
			return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		}
		return new DateTimeOffset(GetFixedLocalDate()).ToUnixTimeMilliseconds();
	}

	private static DateTime GetFixedLocalDate()
	{
		string text = ConfigManager.Config.ServerOption.ServerTime.FixedDate?.Trim();
		if (string.IsNullOrWhiteSpace(text) || text.Equals("today", StringComparison.OrdinalIgnoreCase))
		{
			return DateTime.Today;
		}
		if (DateTime.TryParseExact(text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
		{
			return result.Date;
		}
		if (DateTime.TryParse(text, out result))
		{
			return result.Date;
		}
		return DateTime.Today;
	}
}
