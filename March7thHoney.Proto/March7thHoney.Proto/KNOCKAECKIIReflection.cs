using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KNOCKAECKIIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KNOCKAECKIIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTk9DS0FFQ0tJSS5wcm90bxoRQkREQkFLQk9NS1AucHJvdG8iMAoLS05P" + "Q0tBRUNLSUkSIQoLTEZNS0RKRU9JR0kYAyABKAsyDC5CRERCQUtCT01LUEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BDDBAKBOMKPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KNOCKAECKII), KNOCKAECKII.Parser, new string[1] { "LFMKDJEOIGI" }, null, null, null, null)
		}));
	}
}
