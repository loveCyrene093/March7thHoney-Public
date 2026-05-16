using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicReforgeConfirmScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicReforgeConfirmScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZWxpY1JlZm9yZ2VDb25maXJtU2NSc3AucHJvdG8iKwoYUmVsaWNSZWZv" + "cmdlQ29uZmlybVNjUnNwEg8KB3JldGNvZGUYCiABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicReforgeConfirmScRsp), RelicReforgeConfirmScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
