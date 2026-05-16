using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AEFPNAMECCOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AEFPNAMECCOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRUZQTkFNRUNDTy5wcm90byIiCgtBRUZQTkFNRUNDTxITCgtNQUZNQ0lQ" + "QUlLSxgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AEFPNAMECCO), AEFPNAMECCO.Parser, new string[1] { "MAFMCIPAIKK" }, null, null, null, null)
		}));
	}
}
