using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GBICOFINMIKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GBICOFINMIKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHQklDT0ZJTk1JSy5wcm90byI3CgtHQklDT0ZJTk1JSxITCgtKQkVJTE1G" + "SUlHTRgCIAEoDRITCgtBSEtGRkNJRVBERxgEIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GBICOFINMIK), GBICOFINMIK.Parser, new string[2] { "JBEILMFIIGM", "AHKFFCIEPDG" }, null, null, null, null)
		}));
	}
}
