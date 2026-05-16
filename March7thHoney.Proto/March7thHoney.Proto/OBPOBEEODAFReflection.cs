using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OBPOBEEODAFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OBPOBEEODAFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQlBPQkVFT0RBRi5wcm90bxoRTE5NQkpQSk9OUEUucHJvdG8iMAoLT0JQ" + "T0JFRU9EQUYSIQoLTklJTExNSk5HRUMYBCABKAsyDC5MTk1CSlBKT05QRUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LNMBJPJONPEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OBPOBEEODAF), OBPOBEEODAF.Parser, new string[1] { "NIILLMJNGEC" }, null, null, null, null)
		}));
	}
}
