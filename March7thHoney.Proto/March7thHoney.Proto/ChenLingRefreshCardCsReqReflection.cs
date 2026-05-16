using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingRefreshCardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingRefreshCardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DaGVuTGluZ1JlZnJlc2hDYXJkQ3NSZXEucHJvdG8iGgoYQ2hlbkxpbmdS" + "ZWZyZXNoQ2FyZENzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingRefreshCardCsReq), ChenLingRefreshCardCsReq.Parser, null, null, null, null, null)
		}));
	}
}
