using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BPLDHDFDIDAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BPLDHDFDIDAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCUExESERGRElEQS5wcm90byIeCgtCUExESERGRElEQRIPCgdyZXRjb2Rl" + "GAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BPLDHDFDIDA), BPLDHDFDIDA.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
