using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PCFBJAMCNKJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PCFBJAMCNKJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQ0ZCSkFNQ05LSi5wcm90byI3CgtQQ0ZCSkFNQ05LShITCgtPR0tORUJH" + "REVGThgHIAEoDRITCgtMT0lKTElLT01KThgPIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PCFBJAMCNKJ), PCFBJAMCNKJ.Parser, new string[2] { "OGKNEBGDEFN", "LOIJLIKOMJN" }, null, null, null, null)
		}));
	}
}
