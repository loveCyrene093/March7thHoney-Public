using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IKKMAAEBOKLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IKKMAAEBOKLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJS0tNQUFFQk9LTC5wcm90byI0CgtJS0tNQUFFQk9LTBIQCghwcm9ncmVz" + "cxgFIAEoDRITCgtJQ0ZQUE9MSkRQUBgLIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IKKMAAEBOKL), IKKMAAEBOKL.Parser, new string[2] { "Progress", "ICFPPOLJDPP" }, null, null, null, null)
		}));
	}
}
