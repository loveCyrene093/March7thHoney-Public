using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HIGGMLEFJNIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HIGGMLEFJNIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISUdHTUxFRkpOSS5wcm90byIiCgtISUdHTUxFRkpOSRITCgtQTVBISkZD" + "Q0hIQxgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HIGGMLEFJNI), HIGGMLEFJNI.Parser, new string[1] { "PMPHJFCCHHC" }, null, null, null, null)
		}));
	}
}
