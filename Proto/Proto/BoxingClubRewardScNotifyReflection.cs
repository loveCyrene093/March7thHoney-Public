using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BoxingClubRewardScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BoxingClubRewardScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5Cb3hpbmdDbHViUmV3YXJkU2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnBy";
		buffer[1] = "b3RvInAKGEJveGluZ0NsdWJSZXdhcmRTY05vdGlmeRIZCgZyZXdhcmQYBSAB";
		buffer[2] = "KAsyCS5JdGVtTGlzdBITCgtCS01FREdGT01LRhgGIAEoDRIUCgxjaGFsbGVu";
		buffer[3] = "Z2VfaWQYCyABKA0SDgoGaXNfd2luGA0gASgIQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[4] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BoxingClubRewardScNotify), BoxingClubRewardScNotify.Parser, new string[4] { "Reward", "BKMEDGFOMKF", "ChallengeId", "IsWin" }, null, null, null, null)
		}));
	}
}
