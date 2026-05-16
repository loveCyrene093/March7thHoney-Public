using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HBNJABPHLMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HBNJABPHLMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQk5KQUJQSExNTC5wcm90byIiCgtIQk5KQUJQSExNTBITCgtkaXZpc2lv" + "bl9pZBgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HBNJABPHLML), HBNJABPHLML.Parser, new string[1] { "DivisionId" }, null, null, null, null)
		}));
	}
}
