using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EMJMLBDLMLCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EMJMLBDLMLCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTUpNTEJETE1MQy5wcm90byIeCgtFTUpNTEJETE1MQxIPCgdyZXRjb2Rl" + "GAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EMJMLBDLMLC), EMJMLBDLMLC.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
