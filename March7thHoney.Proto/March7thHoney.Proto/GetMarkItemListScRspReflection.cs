using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMarkItemListScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMarkItemListScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRNYXJrSXRlbUxpc3RTY1JzcC5wcm90byI8ChRHZXRNYXJrSXRlbUxp" + "c3RTY1JzcBITCgtLRklLQ0hKREVHTBgGIAMoDRIPCgdyZXRjb2RlGAogASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMarkItemListScRsp), GetMarkItemListScRsp.Parser, new string[2] { "KFIKCHJDEGL", "Retcode" }, null, null, null, null)
		}));
	}
}
