using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AFDBEFKBBFMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AFDBEFKBBFMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRkRCRUZLQkJGTS5wcm90bxoRTE9DRUpBSU1NR0cucHJvdG8iQgoLQUZE" + "QkVGS0JCRk0SIQoLSlBOQUxLRUZIT0gYAiADKAsyDC5MT0NFSkFJTU1HRxIQ" + "CghsZXZlbF9pZBgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[1] { LOCEJAIMMGGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AFDBEFKBBFM), AFDBEFKBBFM.Parser, new string[2] { "JPNALKEFHOH", "LevelId" }, null, null, null, null)
		}));
	}
}
