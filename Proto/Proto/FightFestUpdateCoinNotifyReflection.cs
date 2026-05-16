using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightFestUpdateCoinNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightFestUpdateCoinNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9GaWdodEZlc3RVcGRhdGVDb2luTm90aWZ5LnByb3RvIi8KGUZpZ2h0RmVz" + "dFVwZGF0ZUNvaW5Ob3RpZnkSEgoKaXRlbV92YWx1ZRgBIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FightFestUpdateCoinNotify), FightFestUpdateCoinNotify.Parser, new string[1] { "ItemValue" }, null, null, null, null)
		}));
	}
}
