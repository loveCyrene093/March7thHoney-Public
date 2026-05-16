using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FOIPOCNEPLNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FOIPOCNEPLNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGT0lQT0NORVBMTi5wcm90bxoRQkxPRURKR0xPQkwucHJvdG8iMAoLRk9J" + "UE9DTkVQTE4SIQoLQk1QUEJLTExQTEEYDCADKAsyDC5CTE9FREpHTE9CTEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BLOEDJGLOBLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FOIPOCNEPLN), FOIPOCNEPLN.Parser, new string[1] { "BMPPBKLLPLA" }, null, null, null, null)
		}));
	}
}
