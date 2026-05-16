using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicReforgeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicReforgeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSZWxpY1JlZm9yZ2VTY1JzcC5wcm90byIkChFSZWxpY1JlZm9yZ2VTY1Jz" + "cBIPCgdyZXRjb2RlGAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicReforgeScRsp), RelicReforgeScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
