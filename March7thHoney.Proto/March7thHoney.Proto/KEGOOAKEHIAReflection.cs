using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KEGOOAKEHIAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KEGOOAKEHIAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLRUdPT0FLRUhJQS5wcm90byIiCgtLRUdPT0FLRUhJQRITCgtISU9GTVBI" + "Q1BKUBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KEGOOAKEHIA), KEGOOAKEHIA.Parser, new string[1] { "HIOFMPHCPJP" }, null, null, null, null)
		}));
	}
}
