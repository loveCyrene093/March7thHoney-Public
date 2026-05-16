using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueShopFormulaInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueShopFormulaInfoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiJHZXRSb2d1ZVNob3BGb3JtdWxhSW5mb1NjUnNwLnByb3RvGhFHRU5PSElK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "SENERy5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIqABChxHZXRSb2d1ZVNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "b3BGb3JtdWxhSW5mb1NjUnNwEiEKC0VDSkNDS0ZFRkVKGAUgASgLMgwuR0VO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "T0hJSkhDREcSEwoLTkVEUE5GREhJR0YYCSABKAUSEwoLQ0FGQkFLRkJOSU4Y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "CiABKAUSDwoHcmV0Y29kZRgNIAEoDRIiCgtBS09DT0FMREVIQxgOIAEoCzIN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "Lkl0ZW1Db3N0RGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			GENOHIJHCDGReflection.Descriptor,
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueShopFormulaInfoScRsp), GetRogueShopFormulaInfoScRsp.Parser, new string[5] { "ECJCCKFEFEJ", "NEDPNFDHIGF", "CAFBAKFBNIN", "Retcode", "AKOCOALDEHC" }, null, null, null, null)
		}));
	}
}
