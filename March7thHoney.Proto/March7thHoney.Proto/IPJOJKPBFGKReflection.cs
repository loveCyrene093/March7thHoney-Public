using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPJOJKPBFGKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPJOJKPBFGKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJUEpPSktQQkZHSy5wcm90byIoCgtJUEpPSktQQkZHSxINCgVsZXZlbBgG" + "IAEoDRIKCgJpZBgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IPJOJKPBFGK), IPJOJKPBFGK.Parser, new string[2] { "Level", "Id" }, null, null, null, null)
		}));
	}
}
