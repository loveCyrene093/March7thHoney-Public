using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NNHPDNACICFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NNHPDNACICFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOTkhQRE5BQ0lDRi5wcm90byIiCgtOTkhQRE5BQ0lDRhITCgtBSUNIQkJJ" + "T0RKQxgIIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NNHPDNACICF), NNHPDNACICF.Parser, new string[1] { "AICHBBIODJC" }, null, null, null, null)
		}));
	}
}
