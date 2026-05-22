using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HEBDKFOFKMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HEBDKFOFKMNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIRUJES0ZPRktNTi5wcm90byIeCgtIRUJES0ZPRktNThIPCgdwZWFrX2lk" + "GAEgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HEBDKFOFKMN), HEBDKFOFKMN.Parser, new string[1] { "PeakId" }, null, null, null, null)
		}));
	}
}
