using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HBFAMLLHFAFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HBFAMLLHFAFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQkZBTUxMSEZBRi5wcm90byI3CgtIQkZBTUxMSEZBRhITCgtLUEtCRUxB" + "SE5ISRgBIAEoARITCgtBQkJIS0VFRUxLTBgCIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HBFAMLLHFAF), HBFAMLLHFAF.Parser, new string[2] { "KPKBELAHNHI", "ABBHKEEELKL" }, null, null, null, null)
		}));
	}
}
