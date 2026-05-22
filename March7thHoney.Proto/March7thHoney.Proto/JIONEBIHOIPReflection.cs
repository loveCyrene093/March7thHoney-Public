using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JIONEBIHOIPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JIONEBIHOIPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKSU9ORUJJSE9JUC5wcm90byJMCgtKSU9ORUJJSE9JUBITCgtFQ0lFQkdD" + "Q0NHQxgCIAEoCBITCgtQTU1ERkZGTkZJTxgIIAEoDRITCgtMSEVORE9PR0JD" + "SxgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JIONEBIHOIP), JIONEBIHOIP.Parser, new string[3] { "ECIEBGCCCGC", "PMMDFFFNFIO", "LHENDOOGBCK" }, null, null, null, null)
		}));
	}
}
