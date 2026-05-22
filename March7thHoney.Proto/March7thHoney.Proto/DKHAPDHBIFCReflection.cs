using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DKHAPDHBIFCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DKHAPDHBIFCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFES0hBUERIQklGQy5wcm90bypkCgtES0hBUERIQklGQxIbChdES0hBUERI" + "QklGQ19JSkFQUEZFRUxQQRAAEhsKF0RLSEFQREhCSUZDX0lHTU9JS05MQU1F" + "EAESGwoXREtIQVBESEJJRkNfTEtPQkJGTUNQTEsQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(DKHAPDHBIFC) }, null, null));
	}
}
