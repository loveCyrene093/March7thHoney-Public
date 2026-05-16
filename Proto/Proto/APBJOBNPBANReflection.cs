using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APBJOBNPBANReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APBJOBNPBANReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBUEJKT0JOUEJBTi5wcm90byIeCgtBUEJKT0JOUEJBThIPCgdyZXRjb2Rl" + "GAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APBJOBNPBAN), APBJOBNPBAN.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
