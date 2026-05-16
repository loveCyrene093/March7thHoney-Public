using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterActivityStrongChallengeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterActivityStrongChallengeCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidFbnRlckFjdGl2aXR5U3Ryb25nQ2hhbGxlbmdlQ3NSZXEucHJvdG8aG1N0";
		buffer[1] = "cm9uZ0NoYWxsZW5nZUF2YXRhci5wcm90byJ1CiFFbnRlckFjdGl2aXR5U3Ry";
		buffer[2] = "b25nQ2hhbGxlbmdlQ3NSZXESEAoIc3RhZ2VfaWQYBCABKA0SKwoLYXZhdGFy";
		buffer[3] = "X2xpc3QYBSADKAsyFi5TdHJvbmdDaGFsbGVuZ2VBdmF0YXISEQoJYnVmZl9s";
		buffer[4] = "aXN0GAggAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { StrongChallengeAvatarReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterActivityStrongChallengeCsReq), EnterActivityStrongChallengeCsReq.Parser, new string[3] { "StageId", "AvatarList", "BuffList" }, null, null, null, null)
		}));
	}
}
