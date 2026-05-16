using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JGIJGAICGHEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JGIJGAICGHEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKR0lKR0FJQ0dIRS5wcm90byIiCgtKR0lKR0FJQ0dIRRITCgtkaXZpc2lv" + "bl9pZBgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JGIJGAICGHE), JGIJGAICGHE.Parser, new string[1] { "DivisionId" }, null, null, null, null)
		}));
	}
}
