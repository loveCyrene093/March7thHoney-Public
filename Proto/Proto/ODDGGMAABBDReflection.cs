using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ODDGGMAABBDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ODDGGMAABBDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRERHR01BQUJCRC5wcm90byIzCgtPRERHR01BQUJCRBITCgtFUERDR0pC" + "Sk9KTRgBIAMoDRIPCgdpdGVtX2lkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ODDGGMAABBD), ODDGGMAABBD.Parser, new string[2] { "EPDCGJBJOJM", "ItemId" }, null, null, null, null)
		}));
	}
}
