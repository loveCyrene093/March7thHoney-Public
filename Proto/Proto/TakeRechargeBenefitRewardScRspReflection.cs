using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeRechargeBenefitRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeRechargeBenefitRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiRUYWtlUmVjaGFyZ2VCZW5lZml0UmV3YXJkU2NSc3AucHJvdG8aEURIS0NE";
		buffer[1] = "Q0NITEhQLnByb3RvGg5JdGVtTGlzdC5wcm90byJvCh5UYWtlUmVjaGFyZ2VC";
		buffer[2] = "ZW5lZml0UmV3YXJkU2NSc3ASGQoGcmV3YXJkGAQgASgLMgkuSXRlbUxpc3QS";
		buffer[3] = "DwoHcmV0Y29kZRgGIAEoDRIhCgtGSUZIQ0lDSERPSBgKIAEoCzIMLkRIS0NE";
		buffer[4] = "Q0NITEhQQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DHKCDCCHLHPReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRechargeBenefitRewardScRsp), TakeRechargeBenefitRewardScRsp.Parser, new string[3] { "Reward", "Retcode", "FIFHCICHDOH" }, null, null, null, null)
		}));
	}
}
