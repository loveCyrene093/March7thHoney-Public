using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MHKGLMBBCKPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MHKGLMBBCKPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSEtHTE1CQkNLUC5wcm90bypkCgtNSEtHTE1CQkNLUBIbChdNSEtHTE1C" + "QkNLUF9QQ1BESEVMUEtFTRAAEhsKF01IS0dMTUJCQ0tQX0hQSkVCRkZISk5Q" + "EAESGwoXTUhLR0xNQkJDS1BfS0xIRENPUFBMTkcQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MHKGLMBBCKP) }, null, null));
	}
}
