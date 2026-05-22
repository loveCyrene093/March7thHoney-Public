using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EIPPGFCFJEOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EIPPGFCFJEOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFSVBQR0ZDRkpFTy5wcm90byIxCgtFSVBQR0ZDRkpFTxINCgVsZXZlbBgE" + "IAEoDRITCgtBT0tEQkRHRENIQhgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EIPPGFCFJEO), EIPPGFCFJEO.Parser, new string[2] { "Level", "AOKDBDGDCHB" }, null, null, null, null)
		}));
	}
}
