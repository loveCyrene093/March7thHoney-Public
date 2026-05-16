using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EBNNIBGFGIHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EBNNIBGFGIHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQk5OSUJHRkdJSC5wcm90byIeCgtFQk5OSUJHRkdJSBIPCgdyZXRjb2Rl" + "GAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EBNNIBGFGIH), EBNNIBGFGIH.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
