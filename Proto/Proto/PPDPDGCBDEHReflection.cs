using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PPDPDGCBDEHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PPDPDGCBDEHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQUERQREdDQkRFSC5wcm90byIrCgtQUERQREdDQkRFSBIKCgJpZBgCIAEo" + "DRIQCghwcm9ncmVzcxgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PPDPDGCBDEH), PPDPDGCBDEH.Parser, new string[2] { "Id", "Progress" }, null, null, null, null)
		}));
	}
}
