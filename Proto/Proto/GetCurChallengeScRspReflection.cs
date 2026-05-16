using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCurChallengeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCurChallengeScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpHZXRDdXJDaGFsbGVuZ2VTY1JzcC5wcm90bxoSQ3VyQ2hhbGxlbmdlLnBy";
		buffer[1] = "b3RvGhBMaW5ldXBJbmZvLnByb3RvIm8KFEdldEN1ckNoYWxsZW5nZVNjUnNw";
		buffer[2] = "EiQKDWN1cl9jaGFsbGVuZ2UYASABKAsyDS5DdXJDaGFsbGVuZ2USDwoHcmV0";
		buffer[3] = "Y29kZRgLIAEoDRIgCgtsaW5ldXBfbGlzdBgOIAMoCzILLkxpbmV1cEluZm9C";
		buffer[4] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CurChallengeReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurChallengeScRsp), GetCurChallengeScRsp.Parser, new string[3] { "CurChallenge", "Retcode", "LineupList" }, null, null, null, null)
		}));
	}
}
