using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HHAHNNOIEIHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HHAHNNOIEIHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISEFITk5PSUVJSC5wcm90byIrCgtISEFITk5PSUVJSBILCgNrZXkYASAB" + "KAkSDwoHcmV0Y29kZRgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHAHNNOIEIH), HHAHNNOIEIH.Parser, new string[2] { "Key", "Retcode" }, null, null, null, null)
		}));
	}
}
