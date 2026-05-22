using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KMDHLENLIMFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KMDHLENLIMFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTURITEVOTElNRi5wcm90byIeCgtLTURITEVOTElNRhIPCgdyZXRjb2Rl" + "GAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KMDHLENLIMF), KMDHLENLIMF.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
