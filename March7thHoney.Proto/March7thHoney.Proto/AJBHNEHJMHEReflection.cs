using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AJBHNEHJMHEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AJBHNEHJMHEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBSkJITkVISk1IRS5wcm90byIiCgtBSkJITkVISk1IRRITCgtkaWFsb2d1" + "ZV9pZBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AJBHNEHJMHE), AJBHNEHJMHE.Parser, new string[1] { "DialogueId" }, null, null, null, null)
		}));
	}
}
