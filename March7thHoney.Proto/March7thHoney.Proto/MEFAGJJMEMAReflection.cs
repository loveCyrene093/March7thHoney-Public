using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MEFAGJJMEMAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MEFAGJJMEMAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRUZBR0pKTUVNQS5wcm90byIiCgtNRUZBR0pKTUVNQRITCgtIRUpBT09D" + "SEVGRxgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MEFAGJJMEMA), MEFAGJJMEMA.Parser, new string[1] { "HEJAOOCHEFG" }, null, null, null, null)
		}));
	}
}
