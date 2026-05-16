using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JDGBALBMOHFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JDGBALBMOHFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKREdCQUxCTU9IRi5wcm90byIeCgtKREdCQUxCTU9IRhIPCgdyZXRjb2Rl" + "GAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JDGBALBMOHF), JDGBALBMOHF.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
