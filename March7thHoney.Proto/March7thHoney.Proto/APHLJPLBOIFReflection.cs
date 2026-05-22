using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APHLJPLBOIFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APHLJPLBOIFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBUEhMSlBMQk9JRi5wcm90bxoRQkdDRUpEQ0hLQkEucHJvdG8iRQoLQVBI" + "TEpQTEJPSUYSEwoLUE5KSE1HTkVKSkkYBiABKA0SIQoLQUxGSE5FSE9CSkEY" + "ByABKA4yDC5CR0NFSkRDSEtCQUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { BGCEJDCHKBAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APHLJPLBOIF), APHLJPLBOIF.Parser, new string[2] { "PNJHMGNEJJI", "ALFHNEHOBJA" }, null, null, null, null)
		}));
	}
}
