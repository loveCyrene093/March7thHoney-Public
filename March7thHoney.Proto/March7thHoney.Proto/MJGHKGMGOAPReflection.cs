using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MJGHKGMGOAPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MJGHKGMGOAPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSkdIS0dNR09BUC5wcm90byIiCgtNSkdIS0dNR09BUBITCgtJSUtDQ0dG" + "SktBQhgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MJGHKGMGOAP), MJGHKGMGOAP.Parser, new string[1] { "IIKCCGFJKAB" }, null, null, null, null)
		}));
	}
}
