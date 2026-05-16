using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EPPGPHKLHNFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EPPGPHKLHNFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFUFBHUEhLTEhORi5wcm90byJDCgtFUFBHUEhLTEhORhIQCghlbmRfdGlt" + "ZRgBIAEoAxIOCgZzZWFzb24YCyABKA0SEgoKYmVnaW5fdGltZRgPIAEoA0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EPPGPHKLHNF), EPPGPHKLHNF.Parser, new string[3] { "EndTime", "Season", "BeginTime" }, null, null, null, null)
		}));
	}
}
