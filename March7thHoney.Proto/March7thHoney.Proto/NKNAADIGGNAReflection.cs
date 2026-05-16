using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NKNAADIGGNAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NKNAADIGGNAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOS05BQURJR0dOQS5wcm90byI3CgtOS05BQURJR0dOQRITCgtISUVES0hG" + "UFBPRhgLIAEoDRITCgtQSE9HTEVQSEdPRhgOIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NKNAADIGGNA), NKNAADIGGNA.Parser, new string[2] { "HIEDKHFPPOF", "PHOGLEPHGOF" }, null, null, null, null)
		}));
	}
}
