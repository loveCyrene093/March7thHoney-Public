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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChpHZXRDdXJDaGFsbGVuZ2VTY1JzcC5wcm90bxoSQ3VyQ2hhbGxlbmdlLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "b3RvGhBMaW5ldXBJbmZvLnByb3RvIm8KFEdldEN1ckNoYWxsZW5nZVNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EiQKDWN1cl9jaGFsbGVuZ2UYASABKAsyDS5DdXJDaGFsbGVuZ2USDwoHcmV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Y29kZRgLIAEoDRIgCgtsaW5ldXBfbGlzdBgOIAMoCzILLkxpbmV1cEluZm9C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			CurChallengeReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurChallengeScRsp), GetCurChallengeScRsp.Parser, new string[3] { "CurChallenge", "Retcode", "LineupList" }, null, null, null, null)
		}));
	}
}
