using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BLADONILKHOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BLADONILKHOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTEFET05JTEtITy5wcm90byJhCgtCTEFET05JTEtITxITCgtLSkRHR05O" + "RkdHUBgJIAMoDRITCgtCR1BCTE9GQ1BNRxgKIAEoDRITCgtJR0ZFQUhJS0tQ" + "RRgMIAEoDRITCgtORU1GTk1JUE5BTxgNIAEoCEIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BLADONILKHO), BLADONILKHO.Parser, new string[4] { "KJDGGNNFGGP", "BGPBLOFCPMG", "IGFEAHIKKPE", "NEMFNMIPNAO" }, null, null, null, null)
		}));
	}
}
