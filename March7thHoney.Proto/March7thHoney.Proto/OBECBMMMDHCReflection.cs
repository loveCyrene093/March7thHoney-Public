using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OBECBMMMDHCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OBECBMMMDHCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQkVDQk1NTURIQy5wcm90bxoRS0dMT0dNSE9ETkIucHJvdG8iRQoLT0JF" + "Q0JNTU1ESEMSIQoLSU1LT0pLSkFITU0YAiADKAsyDC5LR0xPR01IT0ROQhIT" + "CgtGQU1GQ0lQTEdPThgHIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { KGLOGMHODNBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OBECBMMMDHC), OBECBMMMDHC.Parser, new string[2] { "IMKOJKJAHMM", "FAMFCIPLGON" }, null, null, null, null)
		}));
	}
}
