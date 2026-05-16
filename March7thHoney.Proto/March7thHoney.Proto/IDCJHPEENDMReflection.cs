using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IDCJHPEENDMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IDCJHPEENDMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRENKSFBFRU5ETS5wcm90byIiCgtJRENKSFBFRU5ETRITCgtHUEpISk9P" + "SUpKQxgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IDCJHPEENDM), IDCJHPEENDM.Parser, new string[1] { "GPJHJOOIJJC" }, null, null, null, null)
		}));
	}
}
