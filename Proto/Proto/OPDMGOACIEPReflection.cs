using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OPDMGOACIEPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OPDMGOACIEPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPUERNR09BQ0lFUC5wcm90bxoRR0tERUtKS09JSk4ucHJvdG8iMAoLT1BE" + "TUdPQUNJRVASIQoLRkdBQ0VLTEdHQkUYAyADKAsyDC5HS0RFS0pLT0lKTkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GKDEKJKOIJNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OPDMGOACIEP), OPDMGOACIEP.Parser, new string[1] { "FGACEKLGGBE" }, null, null, null, null)
		}));
	}
}
