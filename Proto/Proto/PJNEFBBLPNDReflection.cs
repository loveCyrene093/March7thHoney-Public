using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PJNEFBBLPNDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PJNEFBBLPNDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQSk5FRkJCTFBORC5wcm90bypkCgtQSk5FRkJCTFBORBIbChdQSk5FRkJC" + "TFBORF9QQ1BESEVMUEtFTRAAEhsKF1BKTkVGQkJMUE5EX0FBRUZBQkZKTUND" + "EAESGwoXUEpORUZCQkxQTkRfS0JMREZJQ0ZFT0cQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PJNEFBBLPND) }, null, null));
	}
}
