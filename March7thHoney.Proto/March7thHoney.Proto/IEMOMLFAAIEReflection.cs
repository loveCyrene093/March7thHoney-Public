using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IEMOMLFAAIEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IEMOMLFAAIEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRU1PTUxGQUFJRS5wcm90byIiCgtJRU1PTUxGQUFJRRITCgtHREZQQkhN" + "TUZFQRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IEMOMLFAAIE), IEMOMLFAAIE.Parser, new string[1] { "GDFPBHMMFEA" }, null, null, null, null)
		}));
	}
}
