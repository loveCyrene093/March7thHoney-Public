using System.Threading.Tasks;
using March7thHoney.Database.Avatar;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.Internationalization;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("lineup", "Game.Command.Lineup.Desc", "Game.Command.Lineup.Usage", "", "")]
public class CommandLineup : ICommand
{
	[CommandMethod("0 mp")]
	public async ValueTask SetLineupMp(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		int count = arg.GetInt(0);
		await arg.Target.Player.LineupManager.GainMp((count == 0) ? 2 : count);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Lineup.PlayerGainedMp", count.ToString()));
	}

	[CommandMethod("0 heal")]
	public async ValueTask HealLineup(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		PlayerInstance player = arg.Target.Player;
		foreach (FormalAvatarInfo formalAvatar in player.LineupManager.GetCurLineup().AvatarData.FormalAvatars)
		{
			formalAvatar.CurrentHp = 10000;
		}
		await player.SendPacket(new PacketSyncLineupNotify(player.LineupManager.GetCurLineup()));
		await arg.SendMsg(I18NManager.Translate("Game.Command.Lineup.HealedAllAvatars"));
	}
}
