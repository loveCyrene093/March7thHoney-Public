using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateShopSellBuffCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateShopSellBuffCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtGYXRlU2hvcFNlbGxCdWZmQ3NSZXEucHJvdG8iVgoVRmF0ZVNob3BTZWxs" + "QnVmZkNzUmVxEhMKC1BIR0NEQU9ITERBGAQgASgIEhMKC09JQlBMTUtLR0dM" + "GAwgASgNEhMKC05QTUFBTk9PQ09KGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateShopSellBuffCsReq), FateShopSellBuffCsReq.Parser, new string[3] { "PHGCDAOHLDA", "OIBPLMKKGGL", "NPMAANOOCOJ" }, null, null, null, null)
		}));
	}
}
