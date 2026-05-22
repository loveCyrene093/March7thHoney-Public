using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AetherDivideTakeChallengeRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AetherDivideTakeChallengeRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CipBZXRoZXJEaXZpZGVUYWtlQ2hhbGxlbmdlUmV3YXJkU2NSc3AucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Dkl0ZW1MaXN0LnByb3RvImgKJEFldGhlckRpdmlkZVRha2VDaGFsbGVuZ2VS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZXdhcmRTY1JzcBIPCgdyZXRjb2RlGAQgASgNEhQKDGNoYWxsZW5nZV9pZBgG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "IAEoDRIZCgZyZXdhcmQYDSABKAsyCS5JdGVtTGlzdEIWqgITTWFyY2g3dGhI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideTakeChallengeRewardScRsp), AetherDivideTakeChallengeRewardScRsp.Parser, new string[3] { "Retcode", "ChallengeId", "Reward" }, null, null, null, null)
		}));
	}
}
