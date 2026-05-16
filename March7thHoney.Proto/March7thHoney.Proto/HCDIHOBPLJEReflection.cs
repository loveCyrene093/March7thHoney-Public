using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HCDIHOBPLJEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HCDIHOBPLJEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQ0RJSE9CUExKRS5wcm90byIiCgtIQ0RJSE9CUExKRRITCgtDTlBPTkZN" + "QUtKTxgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HCDIHOBPLJE), HCDIHOBPLJE.Parser, new string[1] { "CNPONFMAKJO" }, null, null, null, null)
		}));
	}
}
