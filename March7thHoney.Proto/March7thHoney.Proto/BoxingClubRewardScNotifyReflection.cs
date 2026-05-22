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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5Cb3hpbmdDbHViUmV3YXJkU2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "b3RvInAKGEJveGluZ0NsdWJSZXdhcmRTY05vdGlmeRIZCgZyZXdhcmQYBSAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "KAsyCS5JdGVtTGlzdBITCgtCS01FREdGT01LRhgGIAEoDRIUCgxjaGFsbGVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Z2VfaWQYCyABKA0SDgoGaXNfd2luGA0gASgIQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BoxingClubRewardScNotify), BoxingClubRewardScNotify.Parser, new string[4] { "Reward", "BKMEDGFOMKF", "ChallengeId", "IsWin" }, null, null, null, null)
		}));
	}
}
