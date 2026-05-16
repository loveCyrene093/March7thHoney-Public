using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HLJMCIBOBJOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HLJMCIBOBJOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITEpNQ0lCT0JKTy5wcm90bypkCgtITEpNQ0lCT0JKTxIbChdITEpNQ0lC" + "T0JKT19NUExQQUxJS0pIRxAAEhsKF0hMSk1DSUJPQkpPX0ZLTUdOSkdHR0hP" + "EAESGwoXSExKTUNJQk9CSk9fRU5BTUdKSEpHSFAQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(HLJMCIBOBJO) }, null, null));
	}
}
