using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LMGJDLDGKMMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LMGJDLDGKMMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMTUdKRExER0tNTS5wcm90byIeCgtMTUdKRExER0tNTRIPCgdyZXRjb2Rl" + "GAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LMGJDLDGKMM), LMGJDLDGKMM.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
