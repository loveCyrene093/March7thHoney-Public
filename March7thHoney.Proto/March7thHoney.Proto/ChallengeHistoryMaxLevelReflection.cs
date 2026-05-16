using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeHistoryMaxLevelReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeHistoryMaxLevelReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DaGFsbGVuZ2VIaXN0b3J5TWF4TGV2ZWwucHJvdG8iRgoYQ2hhbGxlbmdl" + "SGlzdG9yeU1heExldmVsEg0KBWxldmVsGAwgASgNEhsKE3Jld2FyZF9kaXNw" + "bGF5X3R5cGUYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeHistoryMaxLevel), ChallengeHistoryMaxLevel.Parser, new string[2] { "Level", "RewardDisplayType" }, null, null, null, null)
		}));
	}
}
