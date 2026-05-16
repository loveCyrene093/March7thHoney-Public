using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PCKIOEGAPAIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PCKIOEGAPAIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQ0tJT0VHQVBBSS5wcm90bxoRQkREQkFLQk9NS1AucHJvdG8iMAoLUENL" + "SU9FR0FQQUkSIQoLQ0lHQ0tLR01MSUQYDSADKAsyDC5CRERCQUtCT01LUEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BDDBAKBOMKPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PCKIOEGAPAI), PCKIOEGAPAI.Parser, new string[1] { "CIGCKKGMLID" }, null, null, null, null)
		}));
	}
}
