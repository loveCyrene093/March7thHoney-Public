using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.DailyActive;

public static class DailyActiveDefaults
{
	public const uint FixedPoint = 500u;

	public static readonly uint[] QuestIds = new uint[7] { 2100132u, 2100133u, 2100139u, 2100152u, 2100153u, 2100155u, 2100156u };

	public static List<DailyActivityInfo> CreateLevels(bool isHasTaken)
	{
		int num = 5;
		List<DailyActivityInfo> list = new List<DailyActivityInfo>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<DailyActivityInfo> span = CollectionsMarshal.AsSpan(list);
		span[0] = new DailyActivityInfo
		{
			Level = 1u,
			WorldLevel = 6u,
			DailyActivePoint = 100u,
			IsHasTaken = isHasTaken
		};
		span[1] = new DailyActivityInfo
		{
			Level = 2u,
			WorldLevel = 6u,
			DailyActivePoint = 200u,
			IsHasTaken = isHasTaken
		};
		span[2] = new DailyActivityInfo
		{
			Level = 3u,
			WorldLevel = 6u,
			DailyActivePoint = 300u,
			IsHasTaken = isHasTaken
		};
		span[3] = new DailyActivityInfo
		{
			Level = 4u,
			WorldLevel = 6u,
			DailyActivePoint = 400u,
			IsHasTaken = isHasTaken
		};
		span[4] = new DailyActivityInfo
		{
			Level = 5u,
			WorldLevel = 6u,
			DailyActivePoint = 500u,
			IsHasTaken = isHasTaken
		};
		return list;
	}
}
