using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JHHBIOJHEGLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JHHBIOJHEGLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKSEhCSU9KSEVHTC5wcm90bypkCgtKSEhCSU9KSEVHTBIbChdKSEhCSU9K" + "SEVHTF9DTFBITUFKSklMQRAAEhsKF0pISEJJT0pIRUdMX0JJRkVJTkFLTEhG" + "EAESGwoXSkhIQklPSkhFR0xfUExQTUtDQ1BIT0kQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(JHHBIOJHEGL) }, null, null));
	}
}
