using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LKBIPKDKDNPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LKBIPKDKDNPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMS0JJUEtES0ROUC5wcm90byI3CgtMS0JJUEtES0ROUBITCgtITlBBSERM" + "S0JOUBgDIAEoDRITCgtPUEFLUEJCQVBCShgHIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LKBIPKDKDNP), LKBIPKDKDNP.Parser, new string[2] { "HNPAHDLKBNP", "OPAKPBBAPBJ" }, null, null, null, null)
		}));
	}
}
