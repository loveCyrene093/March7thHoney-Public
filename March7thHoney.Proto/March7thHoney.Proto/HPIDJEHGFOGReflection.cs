using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HPIDJEHGFOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HPIDJEHGFOGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIUElESkVIR0ZPRy5wcm90byIfCgtIUElESkVIR0ZPRxIQCghzdGFnZV9p" + "ZBgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HPIDJEHGFOG), HPIDJEHGFOG.Parser, new string[1] { "StageId" }, null, null, null, null)
		}));
	}
}
