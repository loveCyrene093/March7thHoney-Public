using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CBOFFLPHIBPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CBOFFLPHIBPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQk9GRkxQSElCUC5wcm90byIeCgtDQk9GRkxQSElCUBIPCgdyZXRjb2Rl" + "GAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CBOFFLPHIBP), CBOFFLPHIBP.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
