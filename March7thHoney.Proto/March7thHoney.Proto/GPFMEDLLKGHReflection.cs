using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GPFMEDLLKGHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GPFMEDLLKGHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHUEZNRURMTEtHSC5wcm90byIxCgtHUEZNRURMTEtHSBITCgtOSlBDTURO" + "SE9GTBgDIAEoDRINCgVsZXZlbBgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GPFMEDLLKGH), GPFMEDLLKGH.Parser, new string[2] { "NJPCMDNHOFL", "Level" }, null, null, null, null)
		}));
	}
}
