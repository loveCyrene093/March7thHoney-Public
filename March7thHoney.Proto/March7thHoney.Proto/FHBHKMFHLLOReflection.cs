using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FHBHKMFHLLOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FHBHKMFHLLOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSEJIS01GSExMTy5wcm90byI3CgtGSEJIS01GSExMTxITCgtMREdKTERB" + "TkpKTBgBIAEoDRITCgtNR05HUEdQUElBQRgCIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FHBHKMFHLLO), FHBHKMFHLLO.Parser, new string[2] { "LDGJLDANJJL", "MGNGPGPPIAA" }, null, null, null, null)
		}));
	}
}
