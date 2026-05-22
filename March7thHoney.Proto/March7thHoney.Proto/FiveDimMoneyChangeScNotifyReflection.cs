using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FiveDimMoneyChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FiveDimMoneyChangeScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBGaXZlRGltTW9uZXlDaGFuZ2VTY05vdGlmeS5wcm90byJGChpGaXZlRGlt" + "TW9uZXlDaGFuZ2VTY05vdGlmeRITCgtOREtNT0lOTE9PRRgFIAEoDRITCgtK" + "S0xET0ZCSEFCTRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FiveDimMoneyChangeScNotify), FiveDimMoneyChangeScNotify.Parser, new string[2] { "NDKMOINLOOE", "JKLDOFBHABM" }, null, null, null, null)
		}));
	}
}
