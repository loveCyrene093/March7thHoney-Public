using System.Threading.Tasks;
using March7thHoney.Enums.Avatar;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Internationalization;
using March7thHoney.Proto;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("hero", "Game.Command.Hero.Desc", "Game.Command.Hero.Usage", "", "")]
public class CommandHero : ICommand
{
	[CommandMethod("0 gender")]
	public async ValueTask ChangeGender(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count < 1)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		Gender gender = (Gender)arg.GetInt(0);
		if (gender == Gender.None)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Hero.GenderNotSpecified"));
			return;
		}
		PlayerInstance? player = arg.Target.Player;
		player.Data.CurrentGender = gender;
		await player.ChangeAvatarPathType(8001, MultiPathAvatarTypeEnum.Warrior);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Hero.GenderChanged"));
	}

	[CommandMethod("0 type")]
	public async ValueTask ChangeType(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count < 1)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		MultiPathAvatarTypeEnum multiPathAvatarTypeEnum = (MultiPathAvatarTypeEnum)arg.GetInt(0);
		if (multiPathAvatarTypeEnum == (MultiPathAvatarTypeEnum)0)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Hero.HeroTypeNotSpecified"));
			return;
		}
		await arg.Target.Player.ChangeAvatarPathType(8001, multiPathAvatarTypeEnum);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Hero.HeroTypeChanged"));
	}
}
