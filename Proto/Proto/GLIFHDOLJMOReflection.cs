using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GLIFHDOLJMOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GLIFHDOLJMOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTElGSERPTEpNTy5wcm90bxoRRUZFR0tESEVNRk4ucHJvdG8iMAoLR0xJ" + "RkhET0xKTU8SIQoLRURCS09QRk9CTkYYBiABKAsyDC5FRkVHS0RIRU1GTkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { EFEGKDHEMFNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GLIFHDOLJMO), GLIFHDOLJMO.Parser, new string[1] { "EDBKOPFOBNF" }, null, null, null, null)
		}));
	}
}
