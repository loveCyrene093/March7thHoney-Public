using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AFCBPKOACJDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AFCBPKOACJDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRkNCUEtPQUNKRC5wcm90byI3CgtBRkNCUEtPQUNKRBITCgtLR0NIQUlQ" + "S01JSRgGIAMoDRITCgtPRkhDTkdISkZISRgHIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AFCBPKOACJD), AFCBPKOACJD.Parser, new string[2] { "KGCHAIPKMII", "OFHCNGHJFHI" }, null, null, null, null)
		}));
	}
}
