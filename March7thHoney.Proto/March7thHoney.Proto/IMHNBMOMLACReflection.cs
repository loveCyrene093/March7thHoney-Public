using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IMHNBMOMLACReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IMHNBMOMLACReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTUhOQk1PTUxBQy5wcm90byI3CgtJTUhOQk1PTUxBQxITCgtJSU1LSUZE" + "S0pITxgHIAEoDRITCgtKRFBIQlBIQVBLSBgMIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IMHNBMOMLAC), IMHNBMOMLAC.Parser, new string[2] { "IIMKIFDKJHO", "JDPHBPHAPKH" }, null, null, null, null)
		}));
	}
}
