using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GKHEHCOMHCMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GKHEHCOMHCMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHS0hFSENPTUhDTS5wcm90bypkCgtHS0hFSENPTUhDTRIbChdHS0hFSENP" + "TUhDTV9QQ1BESEVMUEtFTRAAEhsKF0dLSEVIQ09NSENNX05NQkNESUxER05L" + "EAESGwoXR0tIRUhDT01IQ01fS0xIRENPUFBMTkcQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GKHEHCOMHCM) }, null, null));
	}
}
