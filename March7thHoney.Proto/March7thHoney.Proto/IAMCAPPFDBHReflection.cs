using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IAMCAPPFDBHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IAMCAPPFDBHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQU1DQVBQRkRCSC5wcm90bxoRRUZCSU1ORkdNQk0ucHJvdG8iMAoLSUFN" + "Q0FQUEZEQkgSIQoLUElCSEpDTUVPRUEYDCADKAsyDC5FRkJJTU5GR01CTUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { EFBIMNFGMBMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IAMCAPPFDBH), IAMCAPPFDBH.Parser, new string[1] { "PIBHJCMEOEA" }, null, null, null, null)
		}));
	}
}
