using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BPDFEOGCAIJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BPDFEOGCAIJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCUERGRU9HQ0FJSi5wcm90byIxCgtCUERGRU9HQ0FJShITCgtBT0tFSUVI" + "S0tLTBgBIAEoDRINCgV2YWx1ZRgCIAEoAkIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BPDFEOGCAIJ), BPDFEOGCAIJ.Parser, new string[2] { "AOKEIEHKKKL", "Value" }, null, null, null, null)
		}));
	}
}
