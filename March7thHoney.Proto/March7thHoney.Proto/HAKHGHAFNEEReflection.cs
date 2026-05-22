using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HAKHGHAFNEEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HAKHGHAFNEEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQUtIR0hBRk5FRS5wcm90byIeCgtIQUtIR0hBRk5FRRIPCgdyZXRjb2Rl" + "GAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HAKHGHAFNEE), HAKHGHAFNEE.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
