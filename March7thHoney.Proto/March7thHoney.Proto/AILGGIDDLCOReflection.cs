using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AILGGIDDLCOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AILGGIDDLCOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBSUxHR0lERExDTy5wcm90bxoRQU5CT0ZLSEhETkUucHJvdG8iMAoLQUlM" + "R0dJRERMQ08SIQoLSkJPQ09QTkVKTEIYDiADKAsyDC5BTkJPRktISERORUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ANBOFKHHDNEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AILGGIDDLCO), AILGGIDDLCO.Parser, new string[1] { "JBOCOPNEJLB" }, null, null, null, null)
		}));
	}
}
