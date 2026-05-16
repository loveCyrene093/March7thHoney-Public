using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GKMGHIBOOFEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GKMGHIBOOFEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHS01HSElCT09GRS5wcm90bxoRQUdBT0pOTkJBTEEucHJvdG8iMAoLR0tN" + "R0hJQk9PRkUSIQoLS0RJRE5FTEVESkQYBCADKAsyDC5BR0FPSk5OQkFMQUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { AGAOJNNBALAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GKMGHIBOOFE), GKMGHIBOOFE.Parser, new string[1] { "KDIDNELEDJD" }, null, null, null, null)
		}));
	}
}
