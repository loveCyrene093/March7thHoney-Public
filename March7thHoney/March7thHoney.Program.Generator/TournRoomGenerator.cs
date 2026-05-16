using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using March7thHoney.Data;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Custom;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.TournRogue;
using March7thHoney.Util;
using Newtonsoft.Json;

namespace March7thHoney.Program.Generator;

public static class TournRoomGenerator
{
	public static List<int> AllowedFloorIdList { get; set; }

	public static List<RogueTournRoomConfig> SavedRoomInstanceList { get; set; }

	public static Dictionary<RogueTournRoomTypeEnum, List<int>> RoomPrefix { get; set; }

	public static Dictionary<RogueTournRoomTypeEnum, List<int>> RoomFloorDiffPrefix { get; set; }

	public static void GenerateFile(string path)
	{
		foreach (int floorId in AllowedFloorIdList)
		{
			int num = 0;
			int num2 = 0;
			RogueTournRoomTypeEnum key = RogueTournRoomTypeEnum.Unknown;
			bool flag = false;
			Dictionary<RogueTournRoomTypeEnum, List<int>> dictionary = new Dictionary<RogueTournRoomTypeEnum, List<int>>();
			foreach (FloorGroupInfo item in GameData.FloorInfoData.Values.First((FloorInfo x) => x.FloorID == floorId).GroupInstanceList.Where((FloorGroupInfo x) => !x.IsDelete && x.Name.Contains("RogueModule_Tournament") && !x.Name.Contains("Tpl_")))
			{
				if (item.Name.Contains("_Area"))
				{
					if (num > 0 && num2 > 0 && dictionary.Count > 0)
					{
						foreach (KeyValuePair<RogueTournRoomTypeEnum, List<int>> item2 in dictionary)
						{
							FlushRoom(GameData.MapEntranceData.First<KeyValuePair<int, MapEntranceExcel>>((KeyValuePair<int, MapEntranceExcel> x) => x.Value.FloorID == floorId).Key, floorId, num, num2, item2.Value, item2.Key);
						}
					}
					dictionary.Clear();
					num = item.ID;
				}
				else if (item.Name.Contains("_Base"))
				{
					if (num > 0 && num2 > 0 && dictionary.Count > 0)
					{
						foreach (KeyValuePair<RogueTournRoomTypeEnum, List<int>> item3 in dictionary)
						{
							FlushRoom(GameData.MapEntranceData.First<KeyValuePair<int, MapEntranceExcel>>((KeyValuePair<int, MapEntranceExcel> x) => x.Value.FloorID == floorId).Key, floorId, num, num2, item3.Value, item3.Key);
						}
					}
					dictionary.Clear();
					num2 = item.ID;
					flag = false;
					if (item.Name.Contains("_Common"))
					{
						flag = true;
					}
					else if (item.Name.Contains("_Boss"))
					{
						key = RogueTournRoomTypeEnum.Boss;
					}
					else if (item.Name.Contains("_Elite"))
					{
						key = RogueTournRoomTypeEnum.Elite;
					}
					else if (item.Name.Contains("_Shop"))
					{
						key = RogueTournRoomTypeEnum.Shop;
					}
					else if (item.Name.Contains("_Rest"))
					{
						key = RogueTournRoomTypeEnum.Respite;
					}
					else if (item.Name.Contains("_Adventure"))
					{
						key = RogueTournRoomTypeEnum.Adventure;
					}
					else if (item.Name.Contains("_Secret"))
					{
						key = RogueTournRoomTypeEnum.Hidden;
					}
				}
				else
				{
					if (num == 0 || num2 == 0)
					{
						continue;
					}
					if (flag)
					{
						if (item.Name.Contains("Monster"))
						{
							dictionary.TryAdd(RogueTournRoomTypeEnum.Battle, new List<int>());
							dictionary[RogueTournRoomTypeEnum.Battle].Add(item.ID);
						}
						else if (item.Name.Contains("Event"))
						{
							dictionary.TryAdd(RogueTournRoomTypeEnum.Event, new List<int>());
							dictionary[RogueTournRoomTypeEnum.Event].Add(item.ID);
						}
						else if (item.Name.Contains("Coin"))
						{
							dictionary.TryAdd(RogueTournRoomTypeEnum.Coin, new List<int>());
							dictionary[RogueTournRoomTypeEnum.Coin].Add(item.ID);
						}
					}
					else
					{
						dictionary.TryAdd(key, new List<int>());
						dictionary[key].Add(item.ID);
					}
				}
			}
		}
		if (File.Exists(path))
		{
			File.WriteAllText(path, "", Encoding.UTF8);
		}
		File.AppendAllText(path, JsonConvert.SerializeObject(SavedRoomInstanceList, Formatting.Indented), Encoding.UTF8);
		Logger.GetByClassName().Info("Generated in " + path + " Successfully!");
	}

	public static void FlushRoom(int entranceId, int floorId, int areaGroupId, int baseGroupId, List<int> contentGroupIds, RogueTournRoomTypeEnum type)
	{
		int? num = RoomPrefix.GetValueOrDefault(type)?.LastOrDefault((int x) => x != 0);
		if (!num.HasValue)
		{
			num = RoomFloorDiffPrefix.GetValueOrDefault(type)?[AllowedFloorIdList.IndexOf(floorId)];
		}
		if (!(num + entranceId % 1000 * 100 + 20).HasValue)
		{
			int? num2 = 0;
			Logger.GetByClassName().Error($"Cannot find prefix for RoomType {type} at Floor {floorId} (EntranceId {entranceId})");
		}
		SavedRoomInstanceList.Add(new RogueTournRoomConfig
		{
			AnchorGroup = baseGroupId,
			AnchorId = 1,
			DefaultLoadBasicGroup = { areaGroupId, baseGroupId },
			DefaultLoadGroup = contentGroupIds,
			EntranceId = entranceId,
			RoomType = type
		});
	}

	static TournRoomGenerator()
	{
		int num = 4;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<int> span = CollectionsMarshal.AsSpan(list);
		span[0] = 80601001;
		span[1] = 80602001;
		span[2] = 80603001;
		span[3] = 80604001;
		AllowedFloorIdList = list;
		SavedRoomInstanceList = new List<RogueTournRoomConfig>();
		Dictionary<RogueTournRoomTypeEnum, List<int>> dictionary = new Dictionary<RogueTournRoomTypeEnum, List<int>>();
		num = 3;
		List<int> list2 = new List<int>(num);
		CollectionsMarshal.SetCount(list2, num);
		Span<int> span2 = CollectionsMarshal.AsSpan(list2);
		span2[0] = 0;
		span2[1] = 120300000;
		span2[2] = 1120300000;
		dictionary.Add(RogueTournRoomTypeEnum.Battle, list2);
		num = 3;
		List<int> list3 = new List<int>(num);
		CollectionsMarshal.SetCount(list3, num);
		Span<int> span3 = CollectionsMarshal.AsSpan(list3);
		span3[0] = 620500000;
		span3[1] = 320500000;
		span3[2] = 1120500000;
		dictionary.Add(RogueTournRoomTypeEnum.Event, list3);
		num = 3;
		List<int> list4 = new List<int>(num);
		CollectionsMarshal.SetCount(list4, num);
		Span<int> span4 = CollectionsMarshal.AsSpan(list4);
		span4[0] = 420400000;
		span4[1] = 120400000;
		span4[2] = 0;
		dictionary.Add(RogueTournRoomTypeEnum.Encounter, list4);
		num = 3;
		List<int> list5 = new List<int>(num);
		CollectionsMarshal.SetCount(list5, num);
		Span<int> span5 = CollectionsMarshal.AsSpan(list5);
		span5[0] = 420800000;
		span5[1] = 120800000;
		span5[2] = 0;
		dictionary.Add(RogueTournRoomTypeEnum.Reward, list5);
		num = 3;
		List<int> list6 = new List<int>(num);
		CollectionsMarshal.SetCount(list6, num);
		Span<int> span6 = CollectionsMarshal.AsSpan(list6);
		span6[0] = 620600000;
		span6[1] = 0;
		span6[2] = 0;
		dictionary.Add(RogueTournRoomTypeEnum.Coin, list6);
		RoomPrefix = dictionary;
		Dictionary<RogueTournRoomTypeEnum, List<int>> dictionary2 = new Dictionary<RogueTournRoomTypeEnum, List<int>>();
		num = 4;
		List<int> list7 = new List<int>(num);
		CollectionsMarshal.SetCount(list7, num);
		Span<int> span7 = CollectionsMarshal.AsSpan(list7);
		span7[0] = 320100000;
		span7[1] = 320100000;
		span7[2] = 220100000;
		span7[3] = 220100000;
		dictionary2.Add(RogueTournRoomTypeEnum.Boss, list7);
		num = 4;
		List<int> list8 = new List<int>(num);
		CollectionsMarshal.SetCount(list8, num);
		Span<int> span8 = CollectionsMarshal.AsSpan(list8);
		span8[0] = 321000000;
		span8[1] = 321000000;
		span8[2] = 221000000;
		span8[3] = 221000000;
		dictionary2.Add(RogueTournRoomTypeEnum.Respite, list8);
		num = 4;
		List<int> list9 = new List<int>(num);
		CollectionsMarshal.SetCount(list9, num);
		Span<int> span9 = CollectionsMarshal.AsSpan(list9);
		span9[0] = 320200000;
		span9[1] = 320200000;
		span9[2] = 220200000;
		span9[3] = 220200000;
		dictionary2.Add(RogueTournRoomTypeEnum.Elite, list9);
		num = 4;
		List<int> list10 = new List<int>(num);
		CollectionsMarshal.SetCount(list10, num);
		Span<int> span10 = CollectionsMarshal.AsSpan(list10);
		span10[0] = 320700000;
		span10[1] = 320700000;
		span10[2] = 220700000;
		span10[3] = 220700000;
		dictionary2.Add(RogueTournRoomTypeEnum.Shop, list10);
		RoomFloorDiffPrefix = dictionary2;
	}
}
