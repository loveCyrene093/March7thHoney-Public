using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OLOGIALOJDPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OLOGIALOJDPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTE9HSUFMT0pEUC5wcm90byIeCgtPTE9HSUFMT0pEUBIPCgdyZXRjb2Rl" + "GAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OLOGIALOJDP), OLOGIALOJDP.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
