using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NAKPLIGJELPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NAKPLIGJELPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQUtQTElHSkVMUC5wcm90byI3CgtOQUtQTElHSkVMUBITCgtLQkZET1BO" + "T0RCTBgJIAEoDRITCgtCUENFQUNDRU5QThgNIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NAKPLIGJELP), NAKPLIGJELP.Parser, new string[2] { "KBFDOPNODBL", "BPCEACCENPN" }, null, null, null, null)
		}));
	}
}
