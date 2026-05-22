using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RotaterDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RotaterDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFSb3RhdGVyRGF0YS5wcm90byJJCgtSb3RhdGVyRGF0YRITCgtNQkFGSU9D" + "TE1BSRgFIAEoAhIQCghncm91cF9pZBgJIAEoDRITCgtQQk9MTUJMS0RORBgO" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RotaterData), RotaterData.Parser, new string[3] { "MBAFIOCLMAI", "GroupId", "PBOLMBLKDND" }, null, null, null, null)
		}));
	}
}
