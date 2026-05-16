using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Custom;
using March7thHoney.GameServer.Plugin;
using March7thHoney.Internationalization;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("reload", "Game.Command.Reload.Desc", "Game.Command.Reload.Usage", "", "egglink.manage")]
public class CommandReload : ICommand
{
	[CommandMethod("0 banner")]
	public async ValueTask ReloadBanner(CommandArg arg)
	{
		GameData.BannersConfig = ResourceManager.LoadCustomFile<BannersConfig>("Banner", "Banners") ?? new BannersConfig();
		await arg.SendMsg(I18NManager.Translate("Game.Command.Reload.ConfigReloaded", I18NManager.Translate("Word.Banner")));
	}

	[CommandMethod("0 activity")]
	public async ValueTask ReloadActivity(CommandArg arg)
	{
		GameData.ActivityConfig = ResourceManager.LoadCustomFile<ActivityConfig>("Activity", "ActivityConfig") ?? new ActivityConfig();
		await arg.SendMsg(I18NManager.Translate("Game.Command.Reload.ConfigReloaded", I18NManager.Translate("Word.Activity")));
	}

	[CommandMethod("0 videokey")]
	public async ValueTask ReloadVideoKey(CommandArg arg)
	{
		GameData.VideoKeysConfig = ResourceManager.LoadCustomFile<VideoKeysConfig>("VideoKeys", "VideoKeysConfig") ?? new VideoKeysConfig();
		await arg.SendMsg(I18NManager.Translate("Game.Command.Reload.ConfigReloaded", I18NManager.Translate("Word.VideoKeys")));
	}

	[CommandMethod("0 plugin")]
	public async ValueTask ReloadPlugin(CommandArg arg)
	{
		PluginManager.UnloadPlugins();
		PluginManager.LoadPlugins();
		await arg.SendMsg(I18NManager.Translate("Game.Command.Reload.ConfigReloaded", I18NManager.Translate("Word.Plugin")));
	}
}
