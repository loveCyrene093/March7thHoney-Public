using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ODMJACIKEPCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ODMJACIKEPCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRE1KQUNJS0VQQy5wcm90bypkCgtPRE1KQUNJS0VQQxIbChdPRE1KQUNJ" + "S0VQQ19QQ1BESEVMUEtFTRAAEhsKF09ETUpBQ0lLRVBDX0FQRkZFRERLTkJL" + "EAESGwoXT0RNSkFDSUtFUENfRURHT0lBT0RKTEgQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ODMJACIKEPC) }, null, null));
	}
}
