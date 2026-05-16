using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FGCBMGEIGFLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FGCBMGEIGFLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGR0NCTUdFSUdGTC5wcm90byIeCgtGR0NCTUdFSUdGTBIPCgdyZXRjb2Rl" + "GAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FGCBMGEIGFL), FGCBMGEIGFL.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
