using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRechargeGiftInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRechargeGiftInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRSZWNoYXJnZUdpZnRJbmZvQ3NSZXEucHJvdG8iGgoYR2V0UmVjaGFy" + "Z2VHaWZ0SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRechargeGiftInfoCsReq), GetRechargeGiftInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
