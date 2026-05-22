using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DNDKOIOIBINReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DNDKOIOIBINReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETkRLT0lPSUJJTi5wcm90byIeCgtETkRLT0lPSUJJThIPCgdyZXRjb2Rl" + "GAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DNDKOIOIBIN), DNDKOIOIBIN.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
