using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HOPKIOKGEBPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HOPKIOKGEBPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIT1BLSU9LR0VCUC5wcm90bxoRS01DT0NGTkNERUsucHJvdG8iMAoLSE9Q" + "S0lPS0dFQlASIQoLSktQQURQSENPSkoYASADKAsyDC5LTUNPQ0ZOQ0RFS0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { KMCOCFNCDEKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HOPKIOKGEBP), HOPKIOKGEBP.Parser, new string[1] { "JKPADPHCOJJ" }, null, null, null, null)
		}));
	}
}
