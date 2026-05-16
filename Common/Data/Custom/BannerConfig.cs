using System;
using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Gacha;
using March7thHoney.Enums;
using March7thHoney.Proto;
using Newtonsoft.Json;

namespace March7thHoney.Data.Custom;

public class BannerConfig
{
	[JsonProperty("id")]
	public int GachaId { get; set; }

	public long BeginTime { get; set; }

	public long EndTime { get; set; }

	public GachaTypeEnum GachaType { get; set; }

	public List<int> RateUpItems5 { get; set; } = new List<int>();

	public List<int> RateUpItems4 { get; set; } = new List<int>();

	public int GetRateUpItem5Chance { get; set; } = 6;

	public int MaxCount { get; set; } = 90;

	public int EventChance { get; set; } = 50;

	public int DoGacha(List<int> goldAvatars, List<int> purpleAvatars, List<int> purpleWeapons, List<int> goldWeapons, List<int> blueWeapons, GachaData data)
	{
		Random random = new Random();
		data.LastGachaFailedCount++;
		List<int> list = new List<int>();
		list.AddRange(goldAvatars);
		list.AddRange(goldWeapons);
		List<int> list2 = new List<int>();
		list2.AddRange(purpleAvatars);
		list2.AddRange(purpleWeapons);
		int num;
		if (data.LastGachaFailedCount >= MaxCount || IsRateUp())
		{
			data.LastGachaFailedCount = 0;
			if (GachaType == GachaTypeEnum.WeaponUp)
			{
				num = GetRateUpItem5(goldWeapons, data.LastWeaponGachaFailed);
				if (RateUpItems5.Contains(num))
				{
					data.LastWeaponGachaFailed = false;
				}
				else
				{
					data.LastWeaponGachaFailed = true;
				}
			}
			else if (GachaType == GachaTypeEnum.AvatarUp)
			{
				num = GetRateUpItem5(goldAvatars, data.LastAvatarGachaFailed);
				if (RateUpItems5.Contains(num))
				{
					data.LastAvatarGachaFailed = false;
				}
				else
				{
					data.LastAvatarGachaFailed = true;
				}
			}
			else
			{
				num = GetRateUpItem5(list, forceUp: false);
			}
		}
		else if (IsRate4() || data.LastGachaPurpleFailedCount >= 10)
		{
			num = ((!IsRateUp4()) ? list2[random.Next(0, list2.Count)] : RateUpItems4[random.Next(0, RateUpItems4.Count)]);
			data.LastGachaPurpleFailedCount = 0;
		}
		else
		{
			num = blueWeapons[random.Next(0, blueWeapons.Count)];
			data.LastGachaPurpleFailedCount++;
		}
		return num;
	}

	public bool IsEvent()
	{
		return new Random().Next(0, 100) < EventChance;
	}

	public bool IsRateUp()
	{
		return new Random().Next(0, 1000) < GetRateUpItem5Chance;
	}

	public bool IsRateUp4()
	{
		return new Random().Next(0, 100) < 50;
	}

	public bool IsRate4()
	{
		return new Random().Next(0, 100) < 10;
	}

	public int GetRateUpItem5(List<int> gold, bool forceUp)
	{
		Random random = new Random();
		if (IsEvent() || forceUp)
		{
			return RateUpItems5[random.Next(0, RateUpItems5.Count)];
		}
		return gold[random.Next(0, gold.Count)];
	}

	public March7thHoney.Proto.GachaInfo ToInfo(List<int> decideOrder, List<int> goldAvatar)
	{
		March7thHoney.Proto.GachaInfo gachaInfo = new March7thHoney.Proto.GachaInfo
		{
			GachaId = (uint)GachaId,
			DetailUrl = "",
			HistoryUrl = ""
		};
		if (RateUpItems4.Count > 0)
		{
			gachaInfo.CBHAEFNAFLE.AddRange(RateUpItems4.Select((int id) => (uint)id));
		}
		if (GachaType != GachaTypeEnum.Normal)
		{
			gachaInfo.BeginTime = BeginTime;
			gachaInfo.EndTime = EndTime;
		}
		if (GachaId == 1001)
		{
			if (RateUpItems5.Count > 0)
			{
				gachaInfo.PrizeItemList.AddRange(RateUpItems5.Select((int id) => (uint)id));
			}
			gachaInfo.GachaCeiling = new GachaCeiling
			{
				IsClaimed = true,
				AvatarList = { goldAvatar.Select((int id) => new GachaCeilingAvatar
				{
					AvatarId = (uint)id
				}) }
			};
		}
		else
		{
			if (RateUpItems5.Count > 0)
			{
				gachaInfo.PrizeItemList.AddRange(RateUpItems5.Select((int id) => (uint)id));
			}
			if (GachaType == GachaTypeEnum.AvatarUp)
			{
				gachaInfo.ItemDetailList.Add(11u);
			}
		}
		return gachaInfo;
	}
}
