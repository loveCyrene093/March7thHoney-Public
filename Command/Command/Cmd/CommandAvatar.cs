using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.Enums.Avatar;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Internationalization;
using March7thHoney.Proto;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("avatar", "Game.Command.Avatar.Desc", "Game.Command.Avatar.Usage", new string[] { "av", "ava" }, "", "")]
public class CommandAvatar : ICommand
{
	[CommandMethod("talent")]
	public async ValueTask SetTalent(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count < 2)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		int avatarId = arg.GetInt(0);
		int level = arg.GetInt(1);
		if ((level < 0 || level > 10) ? true : false)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.InvalidLevel", I18NManager.Translate("Word.Talent")));
			return;
		}
		PlayerInstance player = arg.Target.Player;
		if (avatarId == -1)
		{
			foreach (KeyValuePair<int, PathInfo> item in player.AvatarManager.AvatarData.FormalAvatars.SelectMany((FormalAvatarInfo avatarInfo) => avatarInfo.PathInfos))
			{
				if (!GameData.AvatarConfigData.TryGetValue(item.Key, out AvatarConfigExcel value))
				{
					continue;
				}
				foreach (AvatarSkillTreeConfigExcel item2 in value.SkillTree.GetValueOrDefault(item.Value.EnhanceId, new List<AvatarSkillTreeConfigExcel>()))
				{
					item.Value.GetSkillTree()[item2.PointID] = Math.Min(level, item2.MaxLevel);
				}
			}
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AllAvatarsLevelSet", I18NManager.Translate("Word.Talent"), level.ToString()));
			await player.SendPacket(new PacketPlayerSyncScNotify(player.AvatarManager.AvatarData.FormalAvatars));
			return;
		}
		if (GameData.MultiplePathAvatarConfigData.TryGetValue(avatarId, out MultiplePathAvatarConfigExcel multiple))
		{
			avatarId = multiple.BaseAvatarID;
		}
		FormalAvatarInfo formalAvatar = player.AvatarManager.GetFormalAvatar(avatarId);
		if (formalAvatar == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarNotFound"));
			return;
		}
		KeyValuePair<int, PathInfo> keyValuePair = formalAvatar.PathInfos.FirstOrDefault<KeyValuePair<int, PathInfo>>((KeyValuePair<int, PathInfo> x) => x.Key == (multiple?.AvatarID ?? avatarId));
		if (keyValuePair.Value == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarNotFound"));
			return;
		}
		GameData.AvatarConfigData.TryGetValue(keyValuePair.Key, out AvatarConfigExcel excel);
		if (excel == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarNotFound"));
			return;
		}
		foreach (AvatarSkillTreeConfigExcel item3 in excel.SkillTree.GetValueOrDefault(keyValuePair.Value.EnhanceId, new List<AvatarSkillTreeConfigExcel>()))
		{
			keyValuePair.Value.GetSkillTree()[item3.PointID] = Math.Min(level, item3.MaxLevel);
		}
		await player.SendPacket(new PacketPlayerSyncScNotify(formalAvatar));
		await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarLevelSet", excel.Name?.Replace("{NICKNAME}", player.Data.Name) ?? avatarId.ToString(), I18NManager.Translate("Word.Talent"), level.ToString()));
	}

	[CommandMethod("get")]
	public async ValueTask GetAvatar(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count < 1)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
		}
		int id = arg.GetInt(0);
		AvatarConfigExcel avatarConfigExcel = await arg.Target.Player.AvatarManager.AddAvatar(id);
		if (avatarConfigExcel == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarFailedGet", id.ToString()));
		}
		else
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarGet", avatarConfigExcel.Name ?? id.ToString()));
		}
	}

	[CommandMethod("rank")]
	public async ValueTask SetRank(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count < 2)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
		}
		int id = arg.GetInt(0);
		int rank = arg.GetInt(1);
		if ((rank < 0 || rank > 6) ? true : false)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.InvalidLevel", I18NManager.Translate("Word.Rank")));
			return;
		}
		if (id == -1)
		{
			arg.Target.Player.AvatarManager.AvatarData.FormalAvatars.ForEach(delegate(FormalAvatarInfo avatar)
			{
				foreach (PathInfo value2 in avatar.PathInfos.Values)
				{
					value2.Rank = Math.Min(rank, 6);
				}
			});
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AllAvatarsLevelSet", I18NManager.Translate("Word.Rank"), rank.ToString()));
			await arg.Target.SendPacket(new PacketPlayerSyncScNotify(arg.Target.Player.AvatarManager.AvatarData.FormalAvatars));
			return;
		}
		if (GameData.MultiplePathAvatarConfigData.TryGetValue(id, out MultiplePathAvatarConfigExcel multiple))
		{
			id = multiple.BaseAvatarID;
		}
		FormalAvatarInfo formalAvatar = arg.Target.Player.AvatarManager.GetFormalAvatar(id);
		if (formalAvatar == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarNotFound"));
			return;
		}
		KeyValuePair<int, PathInfo> keyValuePair = formalAvatar.PathInfos.FirstOrDefault<KeyValuePair<int, PathInfo>>((KeyValuePair<int, PathInfo> x) => x.Key == (multiple?.AvatarID ?? id));
		if (keyValuePair.Value == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarNotFound"));
			return;
		}
		keyValuePair.Value.Rank = Math.Min(rank, 6);
		await arg.Target.SendPacket(new PacketPlayerSyncScNotify(formalAvatar));
		GameData.AvatarConfigData.TryGetValue(id, out AvatarConfigExcel value);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarLevelSet", value?.Name?.Replace("{NICKNAME}", arg.Target.Player.Data.Name) ?? id.ToString(), I18NManager.Translate("Word.Rank"), rank.ToString()));
	}

	[CommandMethod("level")]
	public async ValueTask SetLevel(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count < 2)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		int id = arg.GetInt(0);
		int level = arg.GetInt(1);
		if ((level < 1 || level > 80) ? true : false)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.InvalidLevel", I18NManager.Translate("Word.Avatar")));
			return;
		}
		if (id == -1)
		{
			arg.Target.Player.AvatarManager.AvatarData.FormalAvatars.ForEach(delegate(FormalAvatarInfo avatar)
			{
				avatar.Level = Math.Min(level, 80);
				avatar.Promotion = GameData.GetMinPromotionForLevel(avatar.Level);
			});
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AllAvatarsLevelSet", I18NManager.Translate("Word.Avatar"), level.ToString()));
			await arg.Target.SendPacket(new PacketPlayerSyncScNotify(arg.Target.Player.AvatarManager.AvatarData.FormalAvatars));
			return;
		}
		FormalAvatarInfo formalAvatar = arg.Target.Player.AvatarManager.GetFormalAvatar(id);
		if (formalAvatar == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarNotFound"));
			return;
		}
		formalAvatar.Level = Math.Min(level, 80);
		formalAvatar.Promotion = GameData.GetMinPromotionForLevel(formalAvatar.Level);
		await arg.Target.SendPacket(new PacketPlayerSyncScNotify(formalAvatar));
		GameData.AvatarConfigData.TryGetValue(id, out AvatarConfigExcel value);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarLevelSet", value?.Name?.Replace("{NICKNAME}", arg.Target.Player.Data.Name) ?? id.ToString(), I18NManager.Translate("Word.Avatar"), level.ToString()));
	}

	[CommandMethod("path")]
	public async ValueTask SetPath(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (arg.BasicArgs.Count < 2)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		int avatarId = arg.GetInt(0);
		int pathId = arg.GetInt(1);
		FormalAvatarInfo avatar = arg.Target.Player.AvatarManager.GetFormalAvatar(avatarId);
		if (avatar == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarNotFound"));
			return;
		}
		if (!GameData.MultiplePathAvatarConfigData.ContainsKey(pathId))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Avatar.AvatarNotFound"));
			return;
		}
		await arg.Target.Player.ChangeAvatarPathType(avatarId, (MultiPathAvatarTypeEnum)pathId);
		await arg.Target.SendPacket(new PacketAvatarPathChangedNotify((uint)avatarId, (MultiPathAvatarType)pathId));
		await arg.Target.SendPacket(new PacketPlayerSyncScNotify(avatar));
	}
}
