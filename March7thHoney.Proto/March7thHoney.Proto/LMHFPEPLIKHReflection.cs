using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LMHFPEPLIKHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LMHFPEPLIKHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMTUhGUEVQTElLSC5wcm90byIeCgtMTUhGUEVQTElLSBIPCgdyZXRjb2Rl" + "GAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LMHFPEPLIKH), LMHFPEPLIKH.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
