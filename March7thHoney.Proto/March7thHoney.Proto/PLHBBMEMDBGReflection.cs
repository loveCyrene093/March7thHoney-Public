using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PLHBBMEMDBGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PLHBBMEMDBGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTEhCQk1FTURCRy5wcm90bypkCgtQTEhCQk1FTURCRxIbChdQTEhCQk1F" + "TURCR19OTUhCRUZOTk9BQxAAEhsKF1BMSEJCTUVNREJHX0dCUEZDQU1GRU1D" + "EAESGwoXUExIQkJNRU1EQkdfTkJDR1BCT0pKTUgQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PLHBBMEMDBG) }, null, null));
	}
}
