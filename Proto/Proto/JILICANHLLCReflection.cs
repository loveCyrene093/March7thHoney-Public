using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JILICANHLLCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JILICANHLLCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKSUxJQ0FOSExMQy5wcm90bypkCgtKSUxJQ0FOSExMQxIbChdKSUxJQ0FO" + "SExMQ19QQ1BESEVMUEtFTRAAEhsKF0pJTElDQU5ITExDX0hQSkVCRkZISk5Q" + "EAESGwoXSklMSUNBTkhMTENfS0xIRENPUFBMTkcQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(JILICANHLLC) }, null, null));
	}
}
