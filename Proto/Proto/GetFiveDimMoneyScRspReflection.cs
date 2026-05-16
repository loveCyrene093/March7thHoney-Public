using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFiveDimMoneyScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFiveDimMoneyScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRGaXZlRGltTW9uZXlTY1JzcC5wcm90byJRChRHZXRGaXZlRGltTW9u" + "ZXlTY1JzcBITCgtIRk1MTUpBTExQQxgLIAEoDRIPCgdyZXRjb2RlGAwgASgN" + "EhMKC0hMTEtLR0lGSVBDGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFiveDimMoneyScRsp), GetFiveDimMoneyScRsp.Parser, new string[3] { "HFMLMJALLPC", "Retcode", "HLLKKGIFIPC" }, null, null, null, null)
		}));
	}
}
