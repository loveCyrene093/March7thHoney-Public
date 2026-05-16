using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JKIGGHACECOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JKIGGHACECOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKS0lHR0hBQ0VDTy5wcm90byIiCgtKS0lHR0hBQ0VDTxITCgtkaWFsb2d1" + "ZV9pZBgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JKIGGHACECO), JKIGGHACECO.Parser, new string[1] { "DialogueId" }, null, null, null, null)
		}));
	}
}
