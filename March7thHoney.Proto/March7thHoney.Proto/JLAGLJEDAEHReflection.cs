using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JLAGLJEDAEHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JLAGLJEDAEHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTEFHTEpFREFFSC5wcm90byI3CgtKTEFHTEpFREFFSBITCgtISU9GTVBI" + "Q1BKUBgKIAEoDRITCgtOS0VGQUpDT0lHShgMIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JLAGLJEDAEH), JLAGLJEDAEH.Parser, new string[2] { "HIOFMPHCPJP", "NKEFAJCOIGJ" }, null, null, null, null)
		}));
	}
}
