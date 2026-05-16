using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FEHCHGIGBNCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FEHCHGIGBNCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGRUhDSEdJR0JOQy5wcm90byIiCgtGRUhDSEdJR0JOQxITCgtKSEdMR0tD" + "RFBOQhgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FEHCHGIGBNC), FEHCHGIGBNC.Parser, new string[1] { "JHGLGKCDPNB" }, null, null, null, null)
		}));
	}
}
