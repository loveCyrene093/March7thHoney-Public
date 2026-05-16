using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JLLIDDIBOHIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JLLIDDIBOHIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTExJRERJQk9ISS5wcm90byIuCgtKTExJRERJQk9ISRILCgN1aWQYASAB" + "KA0SEgoKbW9uc3Rlcl9pZBgCIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JLLIDDIBOHI), JLLIDDIBOHI.Parser, new string[2] { "Uid", "MonsterId" }, null, null, null, null)
		}));
	}
}
