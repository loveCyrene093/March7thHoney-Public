using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ICOLOEFHLGDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ICOLOEFHLGDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQ09MT0VGSExHRC5wcm90bxoRTEJCRUdERUxFRUkucHJvdG8iMAoLSUNP" + "TE9FRkhMR0QSIQoLQ0pGQkxITlBIQUsYDSADKAsyDC5MQkJFR0RFTEVFSUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LBBEGDELEEIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ICOLOEFHLGD), ICOLOEFHLGD.Parser, new string[1] { "CJFBLHNPHAK" }, null, null, null, null)
		}));
	}
}
