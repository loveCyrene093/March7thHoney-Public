using System.Collections.Generic;
using System.Linq;
using March7thHoney.Configuration;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Lineup;
using March7thHoney.Database.Quests;
using March7thHoney.Proto;
using March7thHoney.Util;
using SqlSugar;

namespace March7thHoney.Database.Player;

[SugarTable("Player")]
public class PlayerData : BaseDatabaseDataHelper
{
	public string? Name { get; set; } = "";

	public string? Signature { get; set; } = "";

	public int Birthday { get; set; }

	public int CurBasicType { get; set; } = 8002;

	public int HeadIcon { get; set; } = 208002;

	public int PhoneTheme { get; set; } = 221000;

	public int ChatBubble { get; set; } = 220000;

	public int PersonalCard { get; set; } = 253000;

	public int PhoneCase { get; set; } = 254000;

	public int CurrentBgm { get; set; } = 210007;

	public int CurrentPamSkin { get; set; } = 252000;

	public bool IsGenderSet { get; set; }

	public Gender CurrentGender { get; set; } = Gender.Woman;

	public int Level { get; set; } = 1;

	public int Exp { get; set; }

	public int WorldLevel { get; set; }

	public int Scoin { get; set; }

	public int Hcoin { get; set; }

	public int Mcoin { get; set; }

	public int TalentPoints { get; set; }

	public int Pet { get; set; }

	[SugarColumn(IsNullable = true)]
	public int CurMusicLevel { get; set; }

	public int Stamina { get; set; } = 300;

	public double StaminaReserve { get; set; }

	public long NextStaminaRecover { get; set; }

	[SugarColumn(IsNullable = true, IsJson = true)]
	public Position? Pos { get; set; }

	[SugarColumn(IsNullable = true, IsJson = true)]
	public Position? Rot { get; set; }

	[SugarColumn(IsJson = true)]
	public PlayerHeadFrameInfo HeadFrame { get; set; } = new PlayerHeadFrameInfo();

	[SugarColumn(IsJson = true)]
	public List<int> PlayerOutfitList { get; set; } = new List<int>();

	[SugarColumn(IsNullable = true)]
	public int PlaneId { get; set; }

	[SugarColumn(IsNullable = true)]
	public int FloorId { get; set; }

	[SugarColumn(IsNullable = true)]
	public int EntryId { get; set; }

	[SugarColumn(IsNullable = true)]
	public long LastActiveTime { get; set; }

	[SugarColumn(IsJson = true)]
	public List<int> TakenLevelReward { get; set; } = new List<int>();

	[SugarColumn(IsJson = true)]
	public PrivacySettingsPb PrivacySettings { get; set; } = new PrivacySettingsPb();

	public static PlayerData? GetPlayerByUid(long uid)
	{
		return DatabaseHelper.Instance?.GetInstance<PlayerData>((int)uid);
	}

	public PlayerBasicInfo ToProto()
	{
		return new PlayerBasicInfo
		{
			Nickname = Name,
			Level = (uint)Level,
			Exp = (uint)Exp,
			WorldLevel = (uint)WorldLevel,
			Scoin = (uint)Scoin,
			Hcoin = (uint)Hcoin,
			Mcoin = (uint)Mcoin,
			Stamina = (uint)Stamina
		};
	}

	public PlayerSimpleInfo ToSimpleProto(FriendOnlineStatus status)
	{
		if (!GameData.ChatBubbleConfigData.ContainsKey(ChatBubble))
		{
			ChatBubble = 220000;
		}
		PlayerSimpleInfo playerSimpleInfo = new PlayerSimpleInfo
		{
			Nickname = Name,
			Level = (uint)Level,
			Signature = Signature,
			Uid = (uint)base.Uid,
			OnlineStatus = status,
			HeadIcon = (uint)HeadIcon,
			Platform = PlatformType.Pc,
			LastActiveTime = LastActiveTime,
			ChatBubbleId = (uint)ChatBubble,
			PersonalCard = (uint)PersonalCard,
			HeadFrameInfo = HeadFrame.ToProto(),
			PlayerOutfitData = ToPlayerOutfitProto(),
			Gender = (uint)CurrentGender
		};
		int num = 0;
		AvatarData instance = DatabaseHelper.Instance.GetInstance<AvatarData>(base.Uid);
		if (instance == null)
		{
			ServerProfile serverProfile = ConfigManager.Config.ServerOption.ServerProfile;
			if (base.Uid == serverProfile.Uid)
			{
				playerSimpleInfo.OnlineStatus = FriendOnlineStatus.Online;
				playerSimpleInfo.AssistSimpleInfoList.AddRange(serverProfile.AssistInfo.Select((ServerAssistInfo x, int index) => new AssistSimpleInfo
				{
					AvatarId = (uint)x.AvatarId,
					Level = (uint)x.Level,
					DressedSkinId = (uint)x.SkinId,
					Pos = (uint)index
				}));
			}
			return playerSimpleInfo;
		}
		foreach (FormalAvatarInfo item in instance.AssistAvatars.Select((int assist) => instance.FormalAvatars.Find((FormalAvatarInfo x) => x.AvatarId == assist)))
		{
			if (item != null)
			{
				playerSimpleInfo.AssistSimpleInfoList.Add(new AssistSimpleInfo
				{
					AvatarId = (uint)item.AvatarId,
					Level = (uint)item.Level,
					DressedSkinId = (uint)item.GetCurPathInfo().Skin,
					Pos = (uint)num++
				});
			}
		}
		return playerSimpleInfo;
	}

	public PlayerDetailInfo ToDetailProto()
	{
		PlayerDetailInfo playerDetailInfo = new PlayerDetailInfo
		{
			Nickname = Name,
			Level = (uint)Level,
			Signature = Signature,
			IsBanned = false,
			HeadIcon = (uint)HeadIcon,
			Platform = PlatformType.Pc,
			Uid = (uint)base.Uid,
			WorldLevel = (uint)WorldLevel,
			RecordInfo = new PlayerRecordInfo(),
			HeadFrameInfo = HeadFrame.ToProto()
		};
		AvatarData avatarInfo = DatabaseHelper.Instance.GetInstance<AvatarData>(base.Uid);
		InventoryData instance = DatabaseHelper.Instance.GetInstance<InventoryData>(base.Uid);
		QuestData questInfo = DatabaseHelper.Instance.GetInstance<QuestData>(base.Uid);
		if (avatarInfo == null || instance == null || questInfo == null)
		{
			ServerProfile serverProfile = ConfigManager.Config.ServerOption.ServerProfile;
			if (base.Uid == serverProfile.Uid)
			{
				playerDetailInfo.AssistAvatarList.AddRange(serverProfile.AssistInfo.Select((ServerAssistInfo x, int index) => new DisplayAvatarDetailInfo
				{
					AvatarId = (uint)x.AvatarId,
					Level = (uint)x.Level,
					DressedSkinId = (uint)x.SkinId,
					Pos = (uint)index
				}));
			}
			return playerDetailInfo;
		}
		playerDetailInfo.RecordInfo = new PlayerRecordInfo
		{
			MMFGIPPNEEF = (uint)avatarInfo.FormalAvatars.Count,
			LCEEKBAJPHA = (uint)instance.EquipmentItems.Select((ItemData x) => x.ItemId).ToHashSet().Count,
			KEBOJOIBOKE = (uint)instance.RelicItems.Count,
			LBKCIEBGMAJ = (uint)GameData.AchievementDataData.Values.Select((AchievementDataExcel x) => x.QuestID).ToHashSet().Count(delegate(int x)
			{
				QuestStatus? questStatus = questInfo.Quests.GetValueOrDefault(x)?.QuestStatus;
				if (questStatus.HasValue)
				{
					QuestStatus valueOrDefault = questStatus.GetValueOrDefault();
					if ((uint)(valueOrDefault - 2) <= 1u)
					{
						return true;
					}
				}
				return false;
			}),
			GPJGLLANPIF = (uint)GameData.BackGroundMusicData.Count
		};
		int num = 0;
		foreach (FormalAvatarInfo item in avatarInfo.AssistAvatars.Select((int assist) => avatarInfo.FormalAvatars.Find((FormalAvatarInfo x) => x.BaseAvatarId == assist)))
		{
			if (item != null)
			{
				playerDetailInfo.AssistAvatarList.Add(item.ToDetailProto(num++, new PlayerDataCollection(this, instance, new March7thHoney.Database.Lineup.LineupInfo())));
			}
		}
		num = 0;
		foreach (FormalAvatarInfo item2 in avatarInfo.DisplayAvatars.Select((int display) => avatarInfo.FormalAvatars.Find((FormalAvatarInfo x) => x.BaseAvatarId == display)))
		{
			if (item2 != null)
			{
				playerDetailInfo.DisplayAvatarList.Add(item2.ToDetailProto(num++, new PlayerDataCollection(this, instance, new March7thHoney.Database.Lineup.LineupInfo())));
			}
		}
		return playerDetailInfo;
	}

	public PlayerOutfitInfo ToPlayerOutfitProto()
	{
		PlayerOutfitInfo playerOutfitInfo = new PlayerOutfitInfo();
		playerOutfitInfo.PlayerOutfitList.AddRange(PlayerOutfitList.Select((int x) => (uint)x));
		return playerOutfitInfo;
	}
}
