using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FPDKBGJKPFFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FPDKBGJKPFFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFGUERLQkdKS1BGRi5wcm90bxoZQ2hhbGxlbmdlTGluZXVwTGlzdC5wcm90";
		buffer[1] = "byJxCgtGUERLQkdKS1BGRhIpCgtsaW5ldXBfbGlzdBgBIAMoCzIULkNoYWxs";
		buffer[2] = "ZW5nZUxpbmV1cExpc3QSDQoFbGV2ZWwYByABKA0SEwoLcm91bmRfY291bnQY";
		buffer[3] = "CyABKA0SEwoLQUJKR05CSk1KSkcYDiABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ChallengeLineupListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FPDKBGJKPFF), FPDKBGJKPFF.Parser, new string[4] { "LineupList", "Level", "RoundCount", "ABJGNBJMJJG" }, null, null, null, null)
		}));
	}
}
