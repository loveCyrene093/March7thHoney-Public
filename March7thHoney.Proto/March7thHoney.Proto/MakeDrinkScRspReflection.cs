using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MakeDrinkScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MakeDrinkScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRNYWtlRHJpbmtTY1JzcC5wcm90byJLCg5NYWtlRHJpbmtTY1JzcBITCgtM" + "UENMUEhJQ0RIRxgFIAEoDRIPCgdyZXRjb2RlGAYgASgNEhMKC0RBSUtOS0FM" + "S0NNGA4gASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MakeDrinkScRsp), MakeDrinkScRsp.Parser, new string[3] { "LPCLPHICDHG", "Retcode", "DAIKNKALKCM" }, null, null, null, null)
		}));
	}
}
