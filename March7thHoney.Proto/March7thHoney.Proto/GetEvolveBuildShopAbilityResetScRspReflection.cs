using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetEvolveBuildShopAbilityResetScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetEvolveBuildShopAbilityResetScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CilHZXRFdm9sdmVCdWlsZFNob3BBYmlsaXR5UmVzZXRTY1JzcC5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "R0NIUE5IQkRDRE8ucHJvdG8aEUdQRk1FRExMS0dILnByb3RvIpABCiNHZXRF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "dm9sdmVCdWlsZFNob3BBYmlsaXR5UmVzZXRTY1JzcBIPCgdyZXRjb2RlGAMg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ASgNEiEKC1BNQ0JCTUtNSE5JGAogAygLMgwuR1BGTUVETExLR0gSEgoKaXRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "bV92YWx1ZRgMIAEoDRIhCgtFR0xDS0dLRUNBShgPIAEoDjIMLkdDSFBOSEJE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "Q0RPQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			GCHPNHBDCDOReflection.Descriptor,
			GPFMEDLLKGHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetEvolveBuildShopAbilityResetScRsp), GetEvolveBuildShopAbilityResetScRsp.Parser, new string[4] { "Retcode", "PMCBBMKMHNI", "ItemValue", "EGLCKGKECAJ" }, null, null, null, null)
		}));
	}
}
