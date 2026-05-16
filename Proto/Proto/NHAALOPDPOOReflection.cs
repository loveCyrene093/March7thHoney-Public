using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NHAALOPDPOOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NHAALOPDPOOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSEFBTE9QRFBPTy5wcm90byIeCgtOSEFBTE9QRFBPTxIPCgdyZXRjb2Rl" + "GAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NHAALOPDPOO), NHAALOPDPOO.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
