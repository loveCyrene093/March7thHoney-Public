using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LEDDFOGLMJDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LEDDFOGLMJDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMRURERk9HTE1KRC5wcm90byI3CgtMRURERk9HTE1KRBITCgtCQVBERkZF" + "REFITRgCIAMoDRITCgtPRkhDTkdISkZISRgEIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LEDDFOGLMJD), LEDDFOGLMJD.Parser, new string[2] { "BAPDFFEDAHM", "OFHCNGHJFHI" }, null, null, null, null)
		}));
	}
}
