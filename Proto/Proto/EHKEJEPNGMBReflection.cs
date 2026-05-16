using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EHKEJEPNGMBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EHKEJEPNGMBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFSEtFSkVQTkdNQi5wcm90byJ2CgtFSEtFSkVQTkdNQhITCgtOSU5ORUtG" + "R05MSRgBIAEoDRITCgtOQ0ZIR0lCQ0VCRxgCIAEoDRITCgtGSkhISkVEUEhN" + "QRgDIAEoDRITCgtHTkNPUEpOQkNLSRgEIAEoAxITCgtPRk9NQkZKRURLQxgF" + "IAEoCUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EHKEJEPNGMB), EHKEJEPNGMB.Parser, new string[5] { "NINNEKFGNLI", "NCFHGIBCEBG", "FJHHJEDPHMA", "GNCOPJNBCKI", "OFOMBFJEDKC" }, null, null, null, null)
		}));
	}
}
