using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceGetHandbookCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceGetHandbookCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DYWtlUmFjZUdldEhhbmRib29rQ3NSZXEucHJvdG8iGgoYQ2FrZVJhY2VH" + "ZXRIYW5kYm9va0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceGetHandbookCsReq), CakeRaceGetHandbookCsReq.Parser, null, null, null, null, null)
		}));
	}
}
