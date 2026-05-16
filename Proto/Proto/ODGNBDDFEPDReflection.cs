using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ODGNBDDFEPDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ODGNBDDFEPDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPREdOQkRERkVQRC5wcm90byI3CgtPREdOQkRERkVQRBITCgtHUEZLRktD" + "Q05GSBgGIAEoARITCgtLSUtCRkJKUEFLSBgMIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ODGNBDDFEPD), ODGNBDDFEPD.Parser, new string[2] { "GPFKFKCCNFH", "KIKBFBJPAKH" }, null, null, null, null)
		}));
	}
}
