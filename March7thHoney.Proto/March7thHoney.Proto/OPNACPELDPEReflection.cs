using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OPNACPELDPEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OPNACPELDPEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPUE5BQ1BFTERQRS5wcm90byIiCgtPUE5BQ1BFTERQRRITCgtQSERMTUxI" + "S0lISBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OPNACPELDPE), OPNACPELDPE.Parser, new string[1] { "PHDLMLHKIHH" }, null, null, null, null)
		}));
	}
}
