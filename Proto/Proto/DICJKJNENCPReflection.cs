using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DICJKJNENCPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DICJKJNENCPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFESUNKS0pORU5DUC5wcm90bypkCgtESUNKS0pORU5DUBIbChdESUNKS0pO" + "RU5DUF9HRUJPSE9MQkpQSBAAEhsKF0RJQ0pLSk5FTkNQX0JHS0xPRU1FSEJB" + "EAESGwoXRElDSktKTkVOQ1BfRURCQUtPUEFCUEYQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(DICJKJNENCP) }, null, null));
	}
}
