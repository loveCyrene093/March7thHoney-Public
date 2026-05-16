using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HHNFCCCHHDDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HHNFCCCHHDDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISE5GQ0NDSEhERC5wcm90byJhCgtISE5GQ0NDSEhERBITCgtIR0pETUlG" + "SktQTxgBIAEoBRITCgtMSEFEQUlNTUhNUBgCIAEoBRITCgtCRlBMUEFLUEJM" + "TBgDIAEoBRITCgtQR0RBUERGT0lERBgEIAEoBUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHNFCCCHHDD), HHNFCCCHHDD.Parser, new string[4] { "HGJDMIFJKPO", "LHADAIMMHMP", "BFPLPAKPBLL", "PGDAPDFOIDD" }, null, null, null, null)
		}));
	}
}
