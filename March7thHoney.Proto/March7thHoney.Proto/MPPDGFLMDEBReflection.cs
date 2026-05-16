using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MPPDGFLMDEBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MPPDGFLMDEBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNUFBER0ZMTURFQi5wcm90byINCgtNUFBER0ZMTURFQkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MPPDGFLMDEB), MPPDGFLMDEB.Parser, null, null, null, null, null)
		}));
	}
}
