using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartPartialChallengeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartPartialChallengeScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiBTdGFydFBhcnRpYWxDaGFsbGVuZ2VTY1JzcC5wcm90bxoSQ3VyQ2hhbGxl";
		buffer[1] = "bmdlLnByb3RvGhBMaW5ldXBJbmZvLnByb3RvGg9TY2VuZUluZm8ucHJvdG8i";
		buffer[2] = "iwEKGlN0YXJ0UGFydGlhbENoYWxsZW5nZVNjUnNwEhsKBmxpbmV1cBgBIAEo";
		buffer[3] = "CzILLkxpbmV1cEluZm8SJAoNY3VyX2NoYWxsZW5nZRgGIAEoCzINLkN1ckNo";
		buffer[4] = "YWxsZW5nZRIPCgdyZXRjb2RlGAggASgNEhkKBXNjZW5lGAkgASgLMgouU2Nl";
		buffer[5] = "bmVJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			CurChallengeReflection.Descriptor,
			LineupInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartPartialChallengeScRsp), StartPartialChallengeScRsp.Parser, new string[4] { "Lineup", "CurChallenge", "Retcode", "Scene" }, null, null, null, null)
		}));
	}
}
