using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OHONFMMAJEBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OHONFMMAJEBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSE9ORk1NQUpFQi5wcm90byIiCgtPSE9ORk1NQUpFQhITCgtLR0pIQUlJ" + "UEdIUBgCIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OHONFMMAJEB), OHONFMMAJEB.Parser, new string[1] { "KGJHAIIPGHP" }, null, null, null, null)
		}));
	}
}
