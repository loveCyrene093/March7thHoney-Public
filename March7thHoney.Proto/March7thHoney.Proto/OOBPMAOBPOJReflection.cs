using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OOBPMAOBPOJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OOBPMAOBPOJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPT0JQTUFPQlBPSi5wcm90byJJCgtPT0JQTUFPQlBPShITCgtFTUxJSklC" + "UEJGTBgFIAEoDRITCgtLTEhEQ09QUExORxgKIAEoCBIQCghwcm9ncmVzcxgO" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OOBPMAOBPOJ), OOBPMAOBPOJ.Parser, new string[3] { "EMLIJIBPBFL", "KLHDCOPPLNG", "Progress" }, null, null, null, null)
		}));
	}
}
