using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MPAACMCJIHGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MPAACMCJIHGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNUEFBQ01DSklIRy5wcm90bxoRS0hISEZIRU9ERUQucHJvdG8iMAoLTVBB" + "QUNNQ0pJSEcSIQoLSUFBRkVJTU5FTU0YCiABKAsyDC5LSEhIRkhFT0RFREIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { KHHHFHEODEDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MPAACMCJIHG), MPAACMCJIHG.Parser, new string[1] { "IAAFEIMNEMM" }, null, null, null, null)
		}));
	}
}
