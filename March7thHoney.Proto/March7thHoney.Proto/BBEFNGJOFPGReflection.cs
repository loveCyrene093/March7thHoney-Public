using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BBEFNGJOFPGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BBEFNGJOFPGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQkVGTkdKT0ZQRy5wcm90bxoRREtCSktPREFER00ucHJvdG8iMAoLQkJF" + "Rk5HSk9GUEcSIQoLUEVBQkxERkNNSUMYDCABKAsyDC5ES0JKS09EQURHTUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DKBJKODADGMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BBEFNGJOFPG), BBEFNGJOFPG.Parser, new string[1] { "PEABLDFCMIC" }, null, null, null, null)
		}));
	}
}
