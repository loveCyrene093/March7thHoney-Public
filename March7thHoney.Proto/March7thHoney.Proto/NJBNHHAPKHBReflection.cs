using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NJBNHHAPKHBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NJBNHHAPKHBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSkJOSEhBUEtIQi5wcm90bypkCgtOSkJOSEhBUEtIQhIbChdOSkJOSEhB" + "UEtIQl9QQ1BESEVMUEtFTRAAEhsKF05KQk5ISEFQS0hCX01QRUtQQk1JTUNQ" + "EAESGwoXTkpCTkhIQVBLSEJfR0ZQUExMR1BPR08QAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(NJBNHHAPKHB) }, null, null));
	}
}
