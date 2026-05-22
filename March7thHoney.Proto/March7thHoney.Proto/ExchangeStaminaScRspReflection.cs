using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExchangeStaminaScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExchangeStaminaScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChpFeGNoYW5nZVN0YW1pbmFTY1JzcC5wcm90bxoOSXRlbUNvc3QucHJvdG8i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "kgEKFEV4Y2hhbmdlU3RhbWluYVNjUnNwEiEKDml0ZW1fY29zdF9saXN0GAYg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "AygLMgkuSXRlbUNvc3QSFgoOZXhjaGFuZ2VfdGltZXMYCCABKA0SGQoRbGFz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "dF9yZWNvdmVyX3RpbWUYCSABKAMSDwoHcmV0Y29kZRgOIAEoDRITCgtzdGFt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aW5hX2FkZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemCostReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeStaminaScRsp), ExchangeStaminaScRsp.Parser, new string[5] { "ItemCostList", "ExchangeTimes", "LastRecoverTime", "Retcode", "StaminaAdd" }, null, null, null, null)
		}));
	}
}
