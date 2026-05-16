using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.Internationalization;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("kick", "Game.Command.Kick.Desc", "Game.Command.Kick.Usage", "", "egglink.manage")]
public class CommandKick : ICommand
{
	[CommandDefault]
	public async ValueTask Kick(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		await arg.Target.SendPacket(new PacketPlayerSqueezedScNotify());
		await arg.SendMsg(I18NManager.Translate("Game.Command.Kick.PlayerKicked", arg.Target.Player.Data.Name));
		arg.Target.Stop();
	}
}
