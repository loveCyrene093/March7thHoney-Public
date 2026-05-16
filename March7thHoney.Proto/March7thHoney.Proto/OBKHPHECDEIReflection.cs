using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OBKHPHECDEIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OBKHPHECDEIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQktIUEhFQ0RFSS5wcm90byIzCgtPQktIUEhFQ0RFSRIPCgdyZXRjb2Rl" + "GAUgASgNEhMKC0pQT0tFQURKTlBJGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OBKHPHECDEI), OBKHPHECDEI.Parser, new string[2] { "Retcode", "JPOKEADJNPI" }, null, null, null, null)
		}));
	}
}
