using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MNGIIJPMJBEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MNGIIJPMJBEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTkdJSUpQTUpCRS5wcm90byJMCgtNTkdJSUpQTUpCRRITCgtKQUFNTU5M" + "TUpDRxgHIAEoDRITCgtFQUtCRExLSUVGQxgJIAEoDRITCgtGRklPRkdBRElO" + "TRgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MNGIIJPMJBE), MNGIIJPMJBE.Parser, new string[3] { "JAAMMNLMJCG", "EAKBDLKIEFC", "FFIOFGADINM" }, null, null, null, null)
		}));
	}
}
