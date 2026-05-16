using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IHFDBCJDHEJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IHFDBCJDHEJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJSEZEQkNKREhFSi5wcm90byIiCgtJSEZEQkNKREhFShITCgtEQUNFRE5H" + "SkxCTRgFIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IHFDBCJDHEJ), IHFDBCJDHEJ.Parser, new string[1] { "DACEDNGJLBM" }, null, null, null, null)
		}));
	}
}
