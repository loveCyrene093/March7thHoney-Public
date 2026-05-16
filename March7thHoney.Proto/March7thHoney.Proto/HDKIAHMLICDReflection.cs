using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HDKIAHMLICDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HDKIAHMLICDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIREtJQUhNTElDRC5wcm90byJMCgtIREtJQUhNTElDRBITCgtJSkFOS1BO" + "SEtIQRgDIAEoDRITCgtNQUdDR1BNSEhFQRgJIAEoDRITCgtMR0hPT0tNTk1D" + "TBgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HDKIAHMLICD), HDKIAHMLICD.Parser, new string[3] { "IJANKPNHKHA", "MAGCGPMHHEA", "LGHOOKMNMCL" }, null, null, null, null)
		}));
	}
}
