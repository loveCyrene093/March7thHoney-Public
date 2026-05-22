using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GOFFLGEJENDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GOFFLGEJENDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHT0ZGTEdFSkVORC5wcm90byJMCgtHT0ZGTEdFSkVORBITCgtKRFBIQlBI" + "QVBLSBgEIAEoDRITCgtPQ0dPQ0JHTExFSRgNIAEoDRITCgtOR0JOSVBFTUhN" + "RBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GOFFLGEJEND), GOFFLGEJEND.Parser, new string[3] { "JDPHBPHAPKH", "OCGOCBGLLEI", "NGBNIPEMHMD" }, null, null, null, null)
		}));
	}
}
