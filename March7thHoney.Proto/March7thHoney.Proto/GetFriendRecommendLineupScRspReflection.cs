using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendRecommendLineupScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendRecommendLineupScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiNHZXRGcmllbmRSZWNvbW1lbmRMaW5ldXBTY1JzcC5wcm90bxoRSEJKQ1BJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "T0xFSUMucHJvdG8aEU5GS0VKSklIT0NKLnByb3RvIpEBCh1HZXRGcmllbmRS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "ZWNvbW1lbmRMaW5ldXBTY1JzcBIPCgdyZXRjb2RlGAEgASgNEgsKA2tleRgD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "IAEoDRIaCgR0eXBlGAQgASgOMgwuTkZLRUpKSUhPQ0oSIQoLREFPS0RQSkFD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "SkYYBSADKAsyDC5IQkpDUElPTEVJQxITCgtPRURPTk1CSkZDRxgPIAEoCEIW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			HBJCPIOLEICReflection.Descriptor,
			NFKEJJIHOCJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendRecommendLineupScRsp), GetFriendRecommendLineupScRsp.Parser, new string[5] { "Retcode", "Key", "Type", "DAOKDPJACJF", "OEDONMBJFCG" }, null, null, null, null)
		}));
	}
}
