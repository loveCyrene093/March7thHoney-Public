using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeChallengePeakRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeChallengePeakRewardScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiJUYWtlQ2hhbGxlbmdlUGVha1Jld2FyZFNjUnNwLnByb3RvGh5DaGFsbGVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "Z2VQZWFrUmV3YXJkR3JvdXAucHJvdG8igQEKHFRha2VDaGFsbGVuZ2VQZWFr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "UmV3YXJkU2NSc3ASDwoHcmV0Y29kZRgBIAEoDRIVCg1wZWFrX2dyb3VwX2lk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "GAQgASgNEjkKFnBlYWtfcmV3YXJkX2dyb3VwX2xpc3QYDyADKAsyGS5DaGFs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "bGVuZ2VQZWFrUmV3YXJkR3JvdXBCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { ChallengePeakRewardGroupReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeChallengePeakRewardScRsp), TakeChallengePeakRewardScRsp.Parser, new string[3] { "Retcode", "PeakGroupId", "PeakRewardGroupList" }, null, null, null, null)
		}));
	}
}
