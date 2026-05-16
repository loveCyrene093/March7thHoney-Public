using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarkReadMailScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarkReadMailScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdNYXJrUmVhZE1haWxTY1JzcC5wcm90byIwChFNYXJrUmVhZE1haWxTY1Jz" + "cBIKCgJpZBgOIAEoDRIPCgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarkReadMailScRsp), MarkReadMailScRsp.Parser, new string[2] { "Id", "Retcode" }, null, null, null, null)
		}));
	}
}
