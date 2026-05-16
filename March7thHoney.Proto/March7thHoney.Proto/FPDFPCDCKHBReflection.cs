using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FPDFPCDCKHBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FPDFPCDCKHBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGUERGUENEQ0tIQi5wcm90bxoRUEJJQ0pDUERMR0QucHJvdG8iMAoLRlBE" + "RlBDRENLSEISIQoLUE9GT0NNSUhKSUEYAyABKAsyDC5QQklDSkNQRExHREIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PBICJCPDLGDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FPDFPCDCKHB), FPDFPCDCKHB.Parser, new string[1] { "POFOCMIHJIA" }, null, null, null, null)
		}));
	}
}
