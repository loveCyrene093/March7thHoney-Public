using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JGECJEFKNCOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JGECJEFKNCOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKR0VDSkVGS05DTy5wcm90byIeCgtKR0VDSkVGS05DTxIPCgdyZXRjb2Rl" + "GAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JGECJEFKNCO), JGECJEFKNCO.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
