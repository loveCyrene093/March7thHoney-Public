using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.GridFight.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.GridFight;

public class PacketGridFightEnterBattleStageScRsp : BasePacket
{
	public PacketGridFightEnterBattleStageScRsp(GridFightInstance? inst, BattleInstance? battle)
		: base(8761)
	{
		GridFightEnterBattleStageScRsp gridFightEnterBattleStageScRsp = new GridFightEnterBattleStageScRsp();
		if (inst == null || battle == null)
		{
			gridFightEnterBattleStageScRsp.Retcode = 1u;
		}
		else
		{
			gridFightEnterBattleStageScRsp.BattleInfo = BuildBattleInfo(inst, battle);
		}
		SetData(gridFightEnterBattleStageScRsp);
	}

	private static SceneBattleInfo BuildBattleInfo(GridFightInstance inst, BattleInstance battle)
	{
		SceneBattleInfo sceneBattleInfo = battle.ToProto();
		GridFightLevelEncounter gridFightLevelEncounter = GridFightLevelResolver.Resolve(inst);
		sceneBattleInfo.AFCMOOFGBPK = new OGEOMDJIAGI
		{
			BBDOCJGAEEJ = inst.DivisionId,
			LFKBMDHKPFI = gridFightLevelEncounter.PenaltyBonusRuleId,
			ANBBPPHBCJH = 3u,
			HDCAEIKAPND = 3u,
			OOPPKDAFFDG = 108u,
			Season = inst.Season,
			IsOverlock = inst.IsOverLock,
			GridFightLineupHp = inst.LineupHp,
			OIHHKOJFHFG = new OMBNHGAJANJ
			{
				BNLHIMHFGDK = 1u,
				DCPKPNLKGMM = inst.Level,
				NDOCIKPLKIF = inst.NDOCIKPLKIF,
				SectionId = inst.SectionId
			}
		};
		foreach (uint activePortalBuffId in inst.ActivePortalBuffIds)
		{
			sceneBattleInfo.AFCMOOFGBPK.GridFightPortalBuffList.Add(new MMDJJDEJMMN
			{
				PortalBuffId = activePortalBuffId
			});
		}
		foreach (var item3 in from kv in inst.UniqueIdByPos
			orderby kv.Key
			where kv.Key != 0 && kv.Key <= 13 && kv.Value != 0 && inst.RoleByUniqueId.ContainsKey(kv.Value)
			select (RoleId: inst.RoleByUniqueId[kv.Value], Pos: kv.Key))
		{
			uint item = item3.RoleId;
			if (!GameData.GridFightRoleBasicInfoData.TryGetValue(item, out GridFightRoleBasicInfoExcel value))
			{
				continue;
			}
			foreach (string roleSavedValue in value.RoleSavedValueList)
			{
				sceneBattleInfo.AFCMOOFGBPK.OGHGLMGJGEM[roleSavedValue] = 0u;
			}
		}
		sceneBattleInfo.AFCMOOFGBPK.OGHGLMGJGEM["GP_Avatar_Sparxie_00"] = 2u;
		PlayerInstance player = battle.Player;
		PlayerDataCollection collection = new PlayerDataCollection(player.Data, player.InventoryManager.Data, battle.Lineup);
		foreach (var item4 in inst.ResolveBackgroundRoles())
		{
			uint item2 = item4.RoleId;
			SpecialAvatarInfo specialAvatarInfo = GridFightBattleProtoBuilder.ResolveTrialAvatar(player, item2);
			if (specialAvatarInfo != null)
			{
				BattleAvatar battleAvatar = specialAvatarInfo.ToBattleProto(collection, AvatarType.AvatarGridFightType);
				battleAvatar.Id = (GameData.GridFightRoleBasicInfoData.TryGetValue(item2, out GridFightRoleBasicInfoExcel value2) ? value2.AvatarID : item2);
				sceneBattleInfo.AFCMOOFGBPK.PIDIGFGKAMK.Add(battleAvatar);
			}
		}
		foreach (IENNMHMOONM item5 in inst.CheckTrait())
		{
			sceneBattleInfo.AFCMOOFGBPK.GridFightTraitInfo.Add(item5);
		}
		foreach (var (num3, num4) in inst.UniqueIdByPos.OrderBy((KeyValuePair<uint, uint> kv) => kv.Key))
		{
			if (num3 != 0 && num3 <= 13 && num4 != 0 && inst.RoleByUniqueId.TryGetValue(num4, out var value3))
			{
				GridFightRoleBasicInfoExcel value4;
				uint avatarId = (GameData.GridFightRoleBasicInfoData.TryGetValue(value3, out value4) ? value4.AvatarID : value3);
				JAJOBJJPINN jAJOBJJPINN = new JAJOBJJPINN
				{
					RoleId = value3,
					AvatarId = avatarId,
					Pos = num3,
					UniqueId = num4,
					RoleStar = inst.RoleStarByUniqueId.GetValueOrDefault(num4, 1u),
					GJEHIGGNIAP = new IFDFHPAMHCL()
				};
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(32u, 180u);
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(33u, 480u);
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(34u, 440u);
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(44u, 304u);
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(49u, 180u);
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(52u, 240u);
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(53u, 480u);
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(57u, 240u);
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(59u, 450u);
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(1013u, 100u);
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(1014u, 100u);
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(1019u, 100u);
				jAJOBJJPINN.ConvertPropertyToFixpoint.Add(1025u, 100u);
				sceneBattleInfo.AFCMOOFGBPK.GridGameRoleList.Add(jAJOBJJPINN);
			}
		}
		return sceneBattleInfo;
	}
}
