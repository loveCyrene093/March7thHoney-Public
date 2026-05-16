using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HADIBEMFDMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HADIBEMFDMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQURJQkVNRkRNTC5wcm90bypkCgtIQURJQkVNRkRNTBIbChdIQURJQkVN" + "RkRNTF9JTUtNUEJNQU1ERxAAEhsKF0hBRElCRU1GRE1MX05DT0FDSURETE9B" + "EAESGwoXSEFESUJFTUZETUxfT0RBS0xOSktOUEYQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(HADIBEMFDML) }, null, null));
	}
}
