using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MCBEKLOKGCDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MCBEKLOKGCDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQ0JFS0xPS0dDRC5wcm90byIxCgtNQ0JFS0xPS0dDRBITCgtOT0VJTk1Q" + "T05PTBgHIAEoDRINCgV2YWx1ZRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MCBEKLOKGCD), MCBEKLOKGCD.Parser, new string[2] { "NOEINMPONOL", "Value" }, null, null, null, null)
		}));
	}
}
