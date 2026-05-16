using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterSectionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterSectionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdFbnRlclNlY3Rpb25TY1JzcC5wcm90byIkChFFbnRlclNlY3Rpb25TY1Jz" + "cBIPCgdyZXRjb2RlGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterSectionScRsp), EnterSectionScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
