using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OMLODGBICOKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OMLODGBICOKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTUxPREdCSUNPSy5wcm90bypkCgtPTUxPREdCSUNPSxIbChdPTUxPREdC" + "SUNPS19PREFKQkpOSkFNRBAAEhsKF09NTE9ER0JJQ09LX0lJQU5JR0RNS0lP" + "EAESGwoXT01MT0RHQklDT0tfUEtOQkNGUEJJTkYQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(OMLODGBICOK) }, null, null));
	}
}
