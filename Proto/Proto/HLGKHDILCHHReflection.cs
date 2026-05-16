using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HLGKHDILCHHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HLGKHDILCHHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITEdLSERJTENISC5wcm90byIzCgtITEdLSERJTENISBIPCgdyZXRjb2Rl" + "GAwgASgNEhMKC0tLR0lFRU5DT0lDGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HLGKHDILCHH), HLGKHDILCHH.Parser, new string[2] { "Retcode", "KKGIEENCOIC" }, null, null, null, null)
		}));
	}
}
