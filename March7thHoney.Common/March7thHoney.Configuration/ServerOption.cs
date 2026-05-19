using System;
using System.Collections.Generic;

namespace March7thHoney.Configuration;

public class ServerOption
{
	public string DefaultNickname { get; set; } = "Trailblazer";

	public int StartTrailblazerLevel { get; set; } = 1;

	public bool AutoUpgradeWorldLevel { get; set; } = true;

	public bool EnableMission { get; set; }

	public bool EnableQuest { get; set; } = true;

	public bool AutoLightSection { get; set; } = true;

	public string Language { get; set; } = "EN";

	public string FallbackLanguage { get; set; } = "EN";

	public HashSet<string> DefaultPermissions { get; set; } = new HashSet<string> { "*" };

	public ServerAnnounce ServerAnnounce { get; set; } = new ServerAnnounce();

	public ServerProfile ServerProfile { get; set; } = new ServerProfile();

	public WatermarkConfig Watermark { get; set; } = new WatermarkConfig();

	public bool AutoCreateUser { get; set; } = true;

	public LogOption LogOption { get; set; } = new LogOption();

	public ServerConfig ServerConfig { get; set; } = new ServerConfig();

	public int FarmingDropRate { get; set; } = 1;

	public bool UseCache { get; set; } = true;

	public bool EnableMonthCard { get; set; } = true;

	public ServerTimeOption ServerTime { get; set; } = new ServerTimeOption();

	public WelcomeMailConfig WelcomeMail { get; set; } = new WelcomeMailConfig();

	public int ValidFarmingDropRate()
	{
		return Math.Max(Math.Min(FarmingDropRate, 999), 1);
	}
}
