using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ANAPBEMBBIFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ANAPBEMBBIFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTkFQQkVNQkJJRi5wcm90byINCgtBTkFQQkVNQkJJRkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ANAPBEMBBIF), ANAPBEMBBIF.Parser, null, null, null, null, null)
		}));
	}
}
