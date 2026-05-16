using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HCJKEDJPGHBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HCJKEDJPGHBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQ0pLRURKUEdIQi5wcm90byIeCgtIQ0pLRURKUEdIQhIPCgdyZXRjb2Rl" + "GAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HCJKEDJPGHB), HCJKEDJPGHB.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
