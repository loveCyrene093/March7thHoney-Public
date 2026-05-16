using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OLJCELNELOHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OLJCELNELOHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTEpDRUxORUxPSC5wcm90byIeCgtPTEpDRUxORUxPSBIPCgdyZXRjb2Rl" + "GAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OLJCELNELOH), OLJCELNELOH.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
