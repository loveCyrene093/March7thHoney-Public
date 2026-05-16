using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KBDIBKLEBKPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KBDIBKLEBKPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLQkRJQktMRUJLUC5wcm90byIeCgtLQkRJQktMRUJLUBIPCgdyZXRjb2Rl" + "GAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KBDIBKLEBKP), KBDIBKLEBKP.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
