using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BAPBJANOPLPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BAPBJANOPLPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQVBCSkFOT1BMUC5wcm90byI3CgtCQVBCSkFOT1BMUBITCgtDUEtNQ1BG" + "SUJMRBgLIAEoDRITCgtBRk5FUExLSUhMTBgOIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BAPBJANOPLP), BAPBJANOPLP.Parser, new string[2] { "CPKMCPFIBLD", "AFNEPLKIHLL" }, null, null, null, null)
		}));
	}
}
