using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NODNMNCIBFGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NODNMNCIBFGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOT0ROTU5DSUJGRy5wcm90bypkCgtOT0ROTU5DSUJGRxIbChdOT0ROTU5D" + "SUJGR19QQ1BESEVMUEtFTRAAEhsKF05PRE5NTkNJQkZHX05DTExORUpOQUNN" + "EAESGwoXTk9ETk1OQ0lCRkdfQVBIR0JISUFQSkMQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(NODNMNCIBFG) }, null, null));
	}
}
