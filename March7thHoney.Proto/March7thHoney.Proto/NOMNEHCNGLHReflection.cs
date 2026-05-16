using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NOMNEHCNGLHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NOMNEHCNGLHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOT01ORUhDTkdMSC5wcm90bypkCgtOT01ORUhDTkdMSBIbChdOT01ORUhD" + "TkdMSF9QQ1BESEVMUEtFTRAAEhsKF05PTU5FSENOR0xIX0tMSERDT1BQTE5H" + "EAESGwoXTk9NTkVIQ05HTEhfQk1DSE1BT0lLREUQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(NOMNEHCNGLH) }, null, null));
	}
}
