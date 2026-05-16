using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BADCGBPEANIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BADCGBPEANIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQURDR0JQRUFOSS5wcm90bxoRTkVJTElBUEhBTU4ucHJvdG8iMAoLQkFE" + "Q0dCUEVBTkkSIQoLSk5PQUtFQ0NJSUwYBiADKAsyDC5ORUlMSUFQSEFNTkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { NEILIAPHAMNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BADCGBPEANI), BADCGBPEANI.Parser, new string[1] { "JNOAKECCIIL" }, null, null, null, null)
		}));
	}
}
