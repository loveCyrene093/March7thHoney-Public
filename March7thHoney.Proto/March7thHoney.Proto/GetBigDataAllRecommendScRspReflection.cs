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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 0) = "CiFHZXRCaWdEYXRhQWxsUmVjb21tZW5kU2NSc3AucHJvdG8aIUJpZ0RhdGFS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 1) = "ZWNvbW1lbmRBdmF0YXJSZWxpYy5wcm90bxohQmlnRGF0YVJlY29tbWVuZFJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 2) = "bGljQXZhdGFyLnByb3RvGhpCaWdEYXRhUmVjb21tZW5kVHlwZS5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 3) = "RUJKRE1LUERDTksucHJvdG8iiQIKG0dldEJpZ0RhdGFBbGxSZWNvbW1lbmRT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 4) = "Y1JzcBI2ChdiaWdfZGF0YV9yZWNvbW1lbmRfdHlwZRgCIAEoDjIVLkJpZ0Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 5) = "dGFSZWNvbW1lbmRUeXBlEg8KB3JldGNvZGUYBSABKA0SNAoMcmVsaWNfYXZh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 6) = "dGFyGAQgASgLMhwuQmlnRGF0YVJlY29tbWVuZFJlbGljQXZhdGFySAASIwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 7) = "R0lKT0dLQk1ESVAYDSABKAsyDC5FQkpETUtQRENOS0gAEjQKDGF2YXRhcl9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 8) = "ZWxpYxgPIAEoCzIcLkJpZ0RhdGFSZWNvbW1lbmRBdmF0YXJSZWxpY0gAQhAK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 9) = "DnJlY29tbWVuZF90eXBlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 10) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray11<string>, string>(in buffer, 11))), new FileDescriptor[4]
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
