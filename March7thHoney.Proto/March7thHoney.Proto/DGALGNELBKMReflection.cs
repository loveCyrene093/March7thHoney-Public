using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DGALGNELBKMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DGALGNELBKMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFER0FMR05FTEJLTS5wcm90byIiCgtER0FMR05FTEJLTRITCgtNQUZNQ0lQ" + "QUlLSxgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DGALGNELBKM), DGALGNELBKM.Parser, new string[1] { "MAFMCIPAIKK" }, null, null, null, null)
		}));
	}
}
