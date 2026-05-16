using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HAPBNLELOBIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HAPBNLELOBIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQVBCTkxFTE9CSS5wcm90byINCgtIQVBCTkxFTE9CSUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HAPBNLELOBI), HAPBNLELOBI.Parser, null, null, null, null, null)
		}));
	}
}
