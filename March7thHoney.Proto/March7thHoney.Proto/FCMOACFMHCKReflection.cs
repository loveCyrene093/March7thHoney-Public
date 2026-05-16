using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FCMOACFMHCKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FCMOACFMHCKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQ01PQUNGTUhDSy5wcm90byJGCgtGQ01PQUNGTUhDSxIKCgJpZBgBIAEo" + "DRITCgtKS0NHQ0FNSUZJQRgCIAEoDRIWCg50b3RhbF9wcm9ncmVzcxgDIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FCMOACFMHCK), FCMOACFMHCK.Parser, new string[3] { "Id", "JKCGCAMIFIA", "TotalProgress" }, null, null, null, null)
		}));
	}
}
