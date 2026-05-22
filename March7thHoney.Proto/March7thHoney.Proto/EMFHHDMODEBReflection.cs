using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EMFHHDMODEBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EMFHHDMODEBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTUZISERNT0RFQi5wcm90byJ2CgtFTUZISERNT0RFQhITCgtFQUFEQk9D" + "Sk5BRRgBIAEoDRITCgtCR1BCTE9GQ1BNRxgIIAEoDRITCgtLSkRHR05ORkdH" + "UBgKIAMoDRITCgtJR0ZFQUhJS0tQRRgLIAEoDRITCgtORU1GTk1JUE5BTxgO" + "IAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EMFHHDMODEB), EMFHHDMODEB.Parser, new string[5] { "EAADBOCJNAE", "BGPBLOFCPMG", "KJDGGNNFGGP", "IGFEAHIKKPE", "NEMFNMIPNAO" }, null, null, null, null)
		}));
	}
}
