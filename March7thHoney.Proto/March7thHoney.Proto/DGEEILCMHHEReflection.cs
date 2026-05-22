using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DGEEILCMHHEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DGEEILCMHHEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFER0VFSUxDTUhIRS5wcm90byIeCgtER0VFSUxDTUhIRRIPCgdyZXRjb2Rl" + "GAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DGEEILCMHHE), DGEEILCMHHE.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
