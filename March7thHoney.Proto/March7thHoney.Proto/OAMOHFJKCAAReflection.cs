using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OAMOHFJKCAAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OAMOHFJKCAAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQU1PSEZKS0NBQS5wcm90bxoRQUFHR0tHTUVLS08ucHJvdG8aEU9CTkNH" + "RUlJTU5CLnByb3RvIlMKC09BTU9IRkpLQ0FBEiEKC05LREdLSUJFSU9EGAQg" + "ASgLMgwuQUFHR0tHTUVLS08SIQoLRUhCS1BCT09DSEcYBiADKAsyDC5PQk5D" + "R0VJSU1OQkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			AAGGKGMEKKOReflection.Descriptor,
			OBNCGEIIMNBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OAMOHFJKCAA), OAMOHFJKCAA.Parser, new string[2] { "NKDGKIBEIOD", "EHBKPBOOCHG" }, null, null, null, null)
		}));
	}
}
