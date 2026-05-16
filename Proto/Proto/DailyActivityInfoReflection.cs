using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DailyActivityInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DailyActivityInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdEYWlseUFjdGl2aXR5SW5mby5wcm90byJpChFEYWlseUFjdGl2aXR5SW5m" + "bxINCgVsZXZlbBgFIAEoDRIUCgxpc19oYXNfdGFrZW4YBiABKAgSEwoLd29y" + "bGRfbGV2ZWwYByABKA0SGgoSZGFpbHlfYWN0aXZlX3BvaW50GAogASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DailyActivityInfo), DailyActivityInfo.Parser, new string[4] { "Level", "IsHasTaken", "WorldLevel", "DailyActivePoint" }, null, null, null, null)
		}));
	}
}
