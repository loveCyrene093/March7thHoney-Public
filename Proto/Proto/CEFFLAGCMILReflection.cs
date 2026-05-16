using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CEFFLAGCMILReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CEFFLAGCMILReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDRUZGTEFHQ01JTC5wcm90byIiCgtDRUZGTEFHQ01JTBITCgtDREhLRkRQ" + "TExHRBgDIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CEFFLAGCMIL), CEFFLAGCMIL.Parser, new string[1] { "CDHKFDPLLGD" }, null, null, null, null)
		}));
	}
}
