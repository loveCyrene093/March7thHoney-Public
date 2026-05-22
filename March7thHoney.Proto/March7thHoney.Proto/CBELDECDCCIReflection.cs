using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CBELDECDCCIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CBELDECDCCIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQkVMREVDRENDSS5wcm90byI3CgtDQkVMREVDRENDSRITCgtKTkhBQk9E" + "TUVLUBgBIAEoDRITCgtLREdPQU9NSkFJRxgCIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CBELDECDCCI), CBELDECDCCI.Parser, new string[2] { "JNHABODMEKP", "KDGOAOMJAIG" }, null, null, null, null)
		}));
	}
}
