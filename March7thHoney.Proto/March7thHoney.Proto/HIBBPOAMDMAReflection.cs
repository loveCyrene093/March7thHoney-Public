using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HIBBPOAMDMAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HIBBPOAMDMAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISUJCUE9BTURNQS5wcm90byI3CgtISUJCUE9BTURNQRITCgtKUExDSkdQ" + "Q0ZETxgJIAEoCBITCgtQSEtBSEFITERBRRgPIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HIBBPOAMDMA), HIBBPOAMDMA.Parser, new string[2] { "JPLCJGPCFDO", "PHKAHAHLDAE" }, null, null, null, null)
		}));
	}
}
