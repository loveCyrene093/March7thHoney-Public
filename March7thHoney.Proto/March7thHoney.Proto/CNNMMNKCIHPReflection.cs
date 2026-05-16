using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CNNMMNKCIHPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CNNMMNKCIHPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTk5NTU5LQ0lIUC5wcm90byJhCgtDTk5NTU5LQ0lIUBITCgtQR0JQTE9O" + "T0lQRRgFIAEoDRITCgtNSE1KR1BNS1BETBgGIAEoDRITCgtKTUxNTUpDSU1I" + "QxgLIAEoDRITCgtIR0JHSkFDQU9IQhgMIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CNNMMNKCIHP), CNNMMNKCIHP.Parser, new string[4] { "PGBPLONOIPE", "MHMJGPMKPDL", "JMLMMJCIMHC", "HGBGJACAOHB" }, null, null, null, null)
		}));
	}
}
