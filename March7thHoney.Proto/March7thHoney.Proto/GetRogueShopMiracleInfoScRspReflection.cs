using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueShopMiracleInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueShopMiracleInfoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiJHZXRSb2d1ZVNob3BNaXJhY2xlSW5mb1NjUnNwLnByb3RvGhFJRU1LUE1N";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "SkxMRS5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIqABChxHZXRSb2d1ZVNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "b3BNaXJhY2xlSW5mb1NjUnNwEiIKC0FLT0NPQUxERUhDGAIgASgLMg0uSXRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "bUNvc3REYXRhEhMKC0NBRkJBS0ZCTklOGAMgASgFEiEKC0ZFSUxOSUtOUENC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "GA0gASgLMgwuSUVNS1BNTUpMTEUSEwoLTkVEUE5GREhJR0YYDiABKAUSDwoH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cmV0Y29kZRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			IEMKPMMJLLEReflection.Descriptor,
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueShopMiracleInfoScRsp), GetRogueShopMiracleInfoScRsp.Parser, new string[5] { "AKOCOALDEHC", "CAFBAKFBNIN", "FEILNIKNPCB", "NEDPNFDHIGF", "Retcode" }, null, null, null, null)
		}));
	}
}
