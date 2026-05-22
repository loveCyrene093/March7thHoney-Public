using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GHFBGBPMPFLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GHFBGBPMPFLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHSEZCR0JQTVBGTC5wcm90byI3CgtHSEZCR0JQTVBGTBITCgtCR0JFR0JL" + "R0JIQhgBIAEoDRITCgtJQVBGSklORk5MTxgLIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GHFBGBPMPFL), GHFBGBPMPFL.Parser, new string[2] { "BGBEGBKGBHB", "IAPFJINFNLO" }, null, null, null, null)
		}));
	}
}
