using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FMFMGICMPCAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FMFMGICMPCAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTUZNR0lDTVBDQS5wcm90bypkCgtGTUZNR0lDTVBDQRIbChdGTUZNR0lD" + "TVBDQV9QQ1BESEVMUEtFTRAAEhsKF0ZNRk1HSUNNUENBX0lGUERMQ09JRU5G" + "EAESGwoXRk1GTUdJQ01QQ0FfTkFIRERJRUhKTUEQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FMFMGICMPCA) }, null, null));
	}
}
