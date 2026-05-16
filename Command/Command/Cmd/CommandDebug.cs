using System.IO;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Custom;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server;
using March7thHoney.Internationalization;
using Newtonsoft.Json;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("debug", "Game.Command.Debug.Desc", "Game.Command.Debug.Usage", "", "")]
public class CommandDebug : ICommand
{
	[CommandMethod("0 specific")]
	public async ValueTask SpecificNextStage(CommandArg arg)
	{
		PlayerInstance playerInstance = arg.Target?.Player;
		if (playerInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count == 0)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		if (!int.TryParse(arg.BasicArgs[0], out var result))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		if (!GameData.StageConfigData.TryGetValue(result, out StageConfigExcel value))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Debug.InvalidStageId"));
			return;
		}
		playerInstance.BattleManager.NextBattleStageConfig = value;
		await arg.SendMsg(I18NManager.Translate("Game.Command.Debug.SetStageId"));
	}

	[CommandMethod("0 monster")]
	public async ValueTask AddMonster(CommandArg arg)
	{
		PlayerInstance playerInstance = arg.Target?.Player;
		if (playerInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count == 0)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		if (!int.TryParse(arg.BasicArgs[0], out var result))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		if (!GameData.MonsterConfigData.TryGetValue(result, out MonsterConfigExcel _))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Debug.InvalidStageId"));
			return;
		}
		playerInstance.BattleManager.NextBattleMonsterIds.Add(result);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Debug.SetStageId"));
	}

	[CommandMethod("0 customP")]
	public async ValueTask AddCustomPacket(CommandArg arg)
	{
		Connection conn = arg.Target;
		if (conn == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.Args.Count < 2)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		string path = arg.Args[1];
		if (!File.Exists(path))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Debug.CustomPacketFileNotFound"));
			return;
		}
		CustomPacketQueueConfig customPacketQueueConfig = JsonConvert.DeserializeObject<CustomPacketQueueConfig>(await File.ReadAllTextAsync(path));
		if (customPacketQueueConfig == null || customPacketQueueConfig.Queue.Count == 0)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Debug.CustomPacketFileInvalid"));
			return;
		}
		conn.CustomPacketQueue.Clear();
		conn.CustomPacketQueue.AddRange(customPacketQueueConfig.Queue);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Debug.CustomPacketFileLoaded"));
	}
}
