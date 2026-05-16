using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DressRelicParamReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DressRelicParamReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVEcmVzc1JlbGljUGFyYW0ucHJvdG8iPgoPRHJlc3NSZWxpY1BhcmFtEhcK" + "D3JlbGljX3VuaXF1ZV9pZBgCIAEoDRISCgpyZWxpY190eXBlGAsgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DressRelicParam), DressRelicParam.Parser, new string[2] { "RelicUniqueId", "RelicType" }, null, null, null, null)
		}));
	}
}
