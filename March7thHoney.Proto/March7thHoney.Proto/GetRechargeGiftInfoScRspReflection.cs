using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRechargeGiftInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRechargeGiftInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRSZWNoYXJnZUdpZnRJbmZvU2NSc3AucHJvdG8aEUFCSVBDTktHRk5J" + "LnByb3RvIk4KGEdldFJlY2hhcmdlR2lmdEluZm9TY1JzcBIPCgdyZXRjb2Rl" + "GAEgASgNEiEKC0ZFS0xKQ0FPR0lJGA4gAygLMgwuQUJJUENOS0dGTklCFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ABIPCNKGFNIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRechargeGiftInfoScRsp), GetRechargeGiftInfoScRsp.Parser, new string[2] { "Retcode", "FEKLJCAOGII" }, null, null, null, null)
		}));
	}
}
