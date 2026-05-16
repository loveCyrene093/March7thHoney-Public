using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FOFBDBJBEJEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FOFBDBJBEJEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGT0ZCREJKQkVKRS5wcm90byI3CgtGT0ZCREJKQkVKRRITCgtEUExQQkRL" + "RENLThgJIAEoCBITCgtKQUtORUJOREZGQhgOIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FOFBDBJBEJE), FOFBDBJBEJE.Parser, new string[2] { "DPLPBDKDCKN", "JAKNEBNDFFB" }, null, null, null, null)
		}));
	}
}
