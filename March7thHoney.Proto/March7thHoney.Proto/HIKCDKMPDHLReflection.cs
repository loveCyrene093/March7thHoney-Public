using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HIKCDKMPDHLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HIKCDKMPDHLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISUtDREtNUERITC5wcm90byIiCgtISUtDREtNUERITBITCgtDREhLRkRQ" + "TExHRBgLIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HIKCDKMPDHL), HIKCDKMPDHL.Parser, new string[1] { "CDHKFDPLLGD" }, null, null, null, null)
		}));
	}
}
