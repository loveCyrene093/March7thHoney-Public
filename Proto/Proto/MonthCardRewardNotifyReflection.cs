using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonthCardRewardNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonthCardRewardNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtNb250aENhcmRSZXdhcmROb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnByb3Rv" + "IjIKFU1vbnRoQ2FyZFJld2FyZE5vdGlmeRIZCgZyZXdhcmQYCSABKAsyCS5J" + "dGVtTGlzdEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonthCardRewardNotify), MonthCardRewardNotify.Parser, new string[1] { "Reward" }, null, null, null, null)
		}));
	}
}
