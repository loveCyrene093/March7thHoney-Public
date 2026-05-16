using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ODEGFOPOKADReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ODEGFOPOKADReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPREVHRk9QT0tBRC5wcm90byI3CgtPREVHRk9QT0tBRBITCgtHQUxORU9M" + "TUNQTxgCIAMoDRITCgtMTkROUEdBQ0JKSBgEIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ODEGFOPOKAD), ODEGFOPOKAD.Parser, new string[2] { "GALNEOLMCPO", "LNDNPGACBJH" }, null, null, null, null)
		}));
	}
}
