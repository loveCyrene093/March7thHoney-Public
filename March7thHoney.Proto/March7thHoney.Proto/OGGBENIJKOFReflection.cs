using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OGGBENIJKOFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OGGBENIJKOFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPR0dCRU5JSktPRi5wcm90byIeCgtPR0dCRU5JSktPRhIPCgdyZXRjb2Rl" + "GAggASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OGGBENIJKOF), OGGBENIJKOF.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
