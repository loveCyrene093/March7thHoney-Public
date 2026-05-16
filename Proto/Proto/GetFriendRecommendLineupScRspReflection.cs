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
		buffer[0] = "CiNHZXRGcmllbmRSZWNvbW1lbmRMaW5ldXBTY1JzcC5wcm90bxoRSEJKQ1BJ";
		buffer[1] = "T0xFSUMucHJvdG8aEU5GS0VKSklIT0NKLnByb3RvIpEBCh1HZXRGcmllbmRS";
		buffer[2] = "ZWNvbW1lbmRMaW5ldXBTY1JzcBIPCgdyZXRjb2RlGAEgASgNEgsKA2tleRgD";
		buffer[3] = "IAEoDRIaCgR0eXBlGAQgASgOMgwuTkZLRUpKSUhPQ0oSIQoLREFPS0RQSkFD";
		buffer[4] = "SkYYBSADKAsyDC5IQkpDUElPTEVJQxITCgtPRURPTk1CSkZDRxgPIAEoCEIW";
		buffer[5] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HBJCPIOLEICReflection.Descriptor,
			NFKEJJIHOCJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendRecommendLineupScRsp), GetFriendRecommendLineupScRsp.Parser, new string[5] { "Retcode", "Key", "Type", "DAOKDPJACJF", "OEDONMBJFCG" }, null, null, null, null)
		}));
	}
}
