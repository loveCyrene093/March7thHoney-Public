using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BNIMDKELDBNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BNIMDKELDBNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTklNREtFTERCTi5wcm90byINCgtCTklNREtFTERCTkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNIMDKELDBN), BNIMDKELDBN.Parser, null, null, null, null, null)
		}));
	}
}
