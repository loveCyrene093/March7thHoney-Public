using March7thHoney.Configuration;

namespace March7thHoney.Util.License;

public static class PublicConfigProvider
{
	public static ConfigContainer Create()
	{
		ConfigContainer configContainer = new ConfigContainer();
		configContainer.MuipServer.AdminKey = "March7thHoneyPublicAdminKey";
		configContainer.ServerOption.Language = UtilTools.GetCurrentLanguage();
		configContainer.ServerOption.FallbackLanguage = configContainer.ServerOption.Language;
		configContainer.ServerOption.LogOption.EnableGamePacketLog = false;
		configContainer.ServerOption.LogOption.LogPacketToConsole = false;
		configContainer.ServerOption.LogOption.DisableLogDetailPacket = true;
		configContainer.ServerOption.LogOption.SavePersonalDebugFile = false;
		configContainer.ServerOption.LogOption.LogResourceCacheLoading = false;
		return configContainer;
	}
}
