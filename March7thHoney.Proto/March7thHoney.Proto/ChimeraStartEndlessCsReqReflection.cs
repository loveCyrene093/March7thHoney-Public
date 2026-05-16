using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraStartEndlessCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraStartEndlessCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DaGltZXJhU3RhcnRFbmRsZXNzQ3NSZXEucHJvdG8iGgoYQ2hpbWVyYVN0" + "YXJ0RW5kbGVzc0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraStartEndlessCsReq), ChimeraStartEndlessCsReq.Parser, null, null, null, null, null)
		}));
	}
}
