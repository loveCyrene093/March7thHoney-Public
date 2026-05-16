using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBigDataAllRecommendScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBigDataAllRecommendScRspReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		buffer[0] = "CiFHZXRCaWdEYXRhQWxsUmVjb21tZW5kU2NSc3AucHJvdG8aIUJpZ0RhdGFS";
		buffer[1] = "ZWNvbW1lbmRBdmF0YXJSZWxpYy5wcm90bxohQmlnRGF0YVJlY29tbWVuZFJl";
		buffer[2] = "bGljQXZhdGFyLnByb3RvGhpCaWdEYXRhUmVjb21tZW5kVHlwZS5wcm90bxoR";
		buffer[3] = "RUJKRE1LUERDTksucHJvdG8iiQIKG0dldEJpZ0RhdGFBbGxSZWNvbW1lbmRT";
		buffer[4] = "Y1JzcBI2ChdiaWdfZGF0YV9yZWNvbW1lbmRfdHlwZRgCIAEoDjIVLkJpZ0Rh";
		buffer[5] = "dGFSZWNvbW1lbmRUeXBlEg8KB3JldGNvZGUYBSABKA0SNAoMcmVsaWNfYXZh";
		buffer[6] = "dGFyGAQgASgLMhwuQmlnRGF0YVJlY29tbWVuZFJlbGljQXZhdGFySAASIwoL";
		buffer[7] = "R0lKT0dLQk1ESVAYDSABKAsyDC5FQkpETUtQRENOS0gAEjQKDGF2YXRhcl9y";
		buffer[8] = "ZWxpYxgPIAEoCzIcLkJpZ0RhdGFSZWNvbW1lbmRBdmF0YXJSZWxpY0gAQhAK";
		buffer[9] = "DnJlY29tbWVuZF90eXBlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[10] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			BigDataRecommendAvatarRelicReflection.Descriptor,
			BigDataRecommendRelicAvatarReflection.Descriptor,
			BigDataRecommendTypeReflection.Descriptor,
			EBJDMKPDCNKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBigDataAllRecommendScRsp), GetBigDataAllRecommendScRsp.Parser, new string[5] { "BigDataRecommendType", "Retcode", "RelicAvatar", "GIJOGKBMDIP", "AvatarRelic" }, new string[1] { "RecommendType" }, null, null, null)
		}));
	}
}
