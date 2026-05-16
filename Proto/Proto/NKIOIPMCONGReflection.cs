using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NKIOIPMCONGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NKIOIPMCONGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOS0lPSVBNQ09ORy5wcm90byIzCgtOS0lPSVBNQ09ORxIPCgdyZXRjb2Rl" + "GAwgASgNEhMKC01PSEhJSkdIUE5CGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NKIOIPMCONG), NKIOIPMCONG.Parser, new string[2] { "Retcode", "MOHHIJGHPNB" }, null, null, null, null)
		}));
	}
}
