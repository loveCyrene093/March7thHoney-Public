using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NJGDKDEDBNBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NJGDKDEDBNBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSkdES0RFREJOQi5wcm90byIiCgtOSkdES0RFREJOQhITCgtQQ0tDSkVQ" + "R05GSxgDIAEoA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NJGDKDEDBNB), NJGDKDEDBNB.Parser, new string[1] { "PCKCJEPGNFK" }, null, null, null, null)
		}));
	}
}
