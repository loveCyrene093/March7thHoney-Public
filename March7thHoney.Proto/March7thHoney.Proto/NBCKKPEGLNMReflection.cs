using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NBCKKPEGLNMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NBCKKPEGLNMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQkNLS1BFR0xOTS5wcm90byIiCgtOQkNLS1BFR0xOTRITCgtNTUtORklG" + "T1BQQRgDIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NBCKKPEGLNM), NBCKKPEGLNM.Parser, new string[1] { "MMKNFIFOPPA" }, null, null, null, null)
		}));
	}
}
