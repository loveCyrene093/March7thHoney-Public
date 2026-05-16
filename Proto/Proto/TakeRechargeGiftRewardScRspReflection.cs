using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeRechargeGiftRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeRechargeGiftRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiFUYWtlUmVjaGFyZ2VHaWZ0UmV3YXJkU2NSc3AucHJvdG8aEUFCSVBDTktH";
		buffer[1] = "Rk5JLnByb3RvGg5JdGVtTGlzdC5wcm90byJsChtUYWtlUmVjaGFyZ2VHaWZ0";
		buffer[2] = "UmV3YXJkU2NSc3ASDwoHcmV0Y29kZRgHIAEoDRIZCgZyZXdhcmQYCyABKAsy";
		buffer[3] = "CS5JdGVtTGlzdBIhCgtFQ0RGRERFT09JTxgPIAEoCzIMLkFCSVBDTktHRk5J";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ABIPCNKGFNIReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRechargeGiftRewardScRsp), TakeRechargeGiftRewardScRsp.Parser, new string[3] { "Retcode", "Reward", "ECDFDDEOOIO" }, null, null, null, null)
		}));
	}
}
