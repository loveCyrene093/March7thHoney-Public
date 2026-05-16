using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OBPNGCPECONReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OBPNGCPECONReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQlBOR0NQRUNPTi5wcm90bxoRT0JFQ0JNTU1ESEMucHJvdG8iMAoLT0JQ" + "TkdDUEVDT04SIQoLTkpFTEdFQkhBT1AYDCABKAsyDC5PQkVDQk1NTURIQ0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { OBECBMMMDHCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OBPNGCPECON), OBPNGCPECON.Parser, new string[1] { "NJELGEBHAOP" }, null, null, null, null)
		}));
	}
}
