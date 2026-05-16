using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AIGKBKIPCNHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AIGKBKIPCNHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBSUdLQktJUENOSC5wcm90bypkCgtBSUdLQktJUENOSBIbChdBSUdLQktJ" + "UENOSF9QQ1BESEVMUEtFTRAAEhsKF0FJR0tCS0lQQ05IX0xFREVFQUhDREtJ" + "EAESGwoXQUlHS0JLSVBDTkhfSENFS0ZFRU5OQ0EQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(AIGKBKIPCNH) }, null, null));
	}
}
