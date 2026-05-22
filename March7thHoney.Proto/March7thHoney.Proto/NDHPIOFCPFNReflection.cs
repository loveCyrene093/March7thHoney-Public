using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NDHPIOFCPFNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NDHPIOFCPFNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOREhQSU9GQ1BGTi5wcm90bypkCgtOREhQSU9GQ1BGThIbChdOREhQSU9G" + "Q1BGTl9QQ1BESEVMUEtFTRAAEhsKF05ESFBJT0ZDUEZOX0ZQT1BNUENPT0ZF" + "EAESGwoXTkRIUElPRkNQRk5fR0pMQkdNRUxCSEoQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(NDHPIOFCPFN) }, null, null));
	}
}
