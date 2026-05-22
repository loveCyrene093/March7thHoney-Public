using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NAFCECEFDMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NAFCECEFDMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQUZDRUNFRkRNTC5wcm90byIeCgtOQUZDRUNFRkRNTBIPCgdyZXRjb2Rl" + "GAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NAFCECEFDML), NAFCECEFDML.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
