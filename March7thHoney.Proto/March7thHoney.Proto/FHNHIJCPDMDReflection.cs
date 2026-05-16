using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FHNHIJCPDMDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FHNHIJCPDMDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSE5ISUpDUERNRC5wcm90bxoRTUtPUEhDQlBPTU0ucHJvdG8iMAoLRkhO" + "SElKQ1BETUQSIQoLS0lPQk9DTU9PTkgYAyABKAsyDC5NS09QSENCUE9NTUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MKOPHCBPOMMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FHNHIJCPDMD), FHNHIJCPDMD.Parser, new string[1] { "KIOBOCMOONH" }, null, null, null, null)
		}));
	}
}
