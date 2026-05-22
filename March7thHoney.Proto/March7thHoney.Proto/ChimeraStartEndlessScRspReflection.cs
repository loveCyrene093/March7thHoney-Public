using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraStartEndlessScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraStartEndlessScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DaGltZXJhU3RhcnRFbmRsZXNzU2NSc3AucHJvdG8iKwoYQ2hpbWVyYVN0" + "YXJ0RW5kbGVzc1NjUnNwEg8KB3JldGNvZGUYAiABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraStartEndlessScRsp), ChimeraStartEndlessScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
