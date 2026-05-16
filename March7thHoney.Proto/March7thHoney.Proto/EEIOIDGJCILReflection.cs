using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EEIOIDGJCILReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EEIOIDGJCILReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRUlPSURHSkNJTC5wcm90bxoRS0hISEZIRU9ERUQucHJvdG8iRQoLRUVJ" + "T0lER0pDSUwSEwoLSkNBQ0RCRkFOQ0IYAyADKA0SIQoLR0RJR0tLR0xMT0YY" + "DyABKAsyDC5LSEhIRkhFT0RFREIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { KHHHFHEODEDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EEIOIDGJCIL), EEIOIDGJCIL.Parser, new string[2] { "JCACDBFANCB", "GDIGKKGLLOF" }, null, null, null, null)
		}));
	}
}
