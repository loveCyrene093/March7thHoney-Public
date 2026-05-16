using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OLDMKCIINGHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OLDMKCIINGHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTERNS0NJSU5HSC5wcm90bxoRUEVFRE5PQk1CTk4ucHJvdG8iVgoLT0xE" + "TUtDSUlOR0gSDwoHcmV0Y29kZRgGIAEoDRITCgtNT0hISUpHSFBOQhgIIAEo" + "DRIhCgtKT0dGREJQQU1EUBgLIAEoCzIMLlBFRUROT0JNQk5OQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PEEDNOBMBNNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OLDMKCIINGH), OLDMKCIINGH.Parser, new string[3] { "Retcode", "MOHHIJGHPNB", "JOGFDBPAMDP" }, null, null, null, null)
		}));
	}
}
