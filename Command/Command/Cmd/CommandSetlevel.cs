using System;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Internationalization;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("setlevel", "Game.Command.Setlevel.Desc", "Game.Command.Setlevel.Usage", new string[] { "level" }, "", "")]
public class CommandSetlevel : ICommand
{
	[CommandDefault]
	public async ValueTask SetLevel(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.Args.Count < 1)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		PlayerInstance? player = arg.Target.Player;
		int level = Math.Max(Math.Min(arg.GetInt(0), 70), 1);
		player.Data.Level = level;
		player.OnLevelChange();
		player.Data.Exp = GameData.GetPlayerExpRequired(level);
		await player.SendPacket(new PacketPlayerSyncScNotify(player.ToProto()));
		await arg.SendMsg(I18NManager.Translate("Game.Command.Setlevel.SetlevelSuccess"));
	}
}
