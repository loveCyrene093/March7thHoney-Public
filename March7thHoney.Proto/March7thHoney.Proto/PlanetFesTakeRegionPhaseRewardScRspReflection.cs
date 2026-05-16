using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesTakeRegionPhaseRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesTakeRegionPhaseRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CilQbGFuZXRGZXNUYWtlUmVnaW9uUGhhc2VSZXdhcmRTY1JzcC5wcm90bxoO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SXRlbUxpc3QucHJvdG8iawojUGxhbmV0RmVzVGFrZVJlZ2lvblBoYXNlUmV3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "YXJkU2NSc3ASHgoLcmV3YXJkX2xpc3QYAyABKAsyCS5JdGVtTGlzdBITCgtI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Sk1HR0xBTkhNTBgHIAEoDRIPCgdyZXRjb2RlGAwgASgNQhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesTakeRegionPhaseRewardScRsp), PlanetFesTakeRegionPhaseRewardScRsp.Parser, new string[3] { "RewardList", "HJMGGLANHML", "Retcode" }, null, null, null, null)
		}));
	}
}
