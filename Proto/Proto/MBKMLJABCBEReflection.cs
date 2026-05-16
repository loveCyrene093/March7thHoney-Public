using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MBKMLJABCBEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MBKMLJABCBEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQktNTEpBQkNCRS5wcm90bypkCgtNQktNTEpBQkNCRRIbChdNQktNTEpB" + "QkNCRV9CTkpNUENIRklOQRAAEhsKF01CS01MSkFCQ0JFX0NDSkNGTUlBRkNN" + "EAESGwoXTUJLTUxKQUJDQkVfQURFQU1OQUhCUEUQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MBKMLJABCBE) }, null, null));
	}
}
