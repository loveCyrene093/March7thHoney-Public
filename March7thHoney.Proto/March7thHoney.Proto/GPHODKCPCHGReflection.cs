using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GPHODKCPCHGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GPHODKCPCHGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHUEhPREtDUENIRy5wcm90byI0CgtHUEhPREtDUENIRxITCgtFREdFSElE" + "TERCRhgGIAEoCBIQCgh0cmFpdF9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GPHODKCPCHG), GPHODKCPCHG.Parser, new string[2] { "EDGEHIDLDBF", "TraitId" }, null, null, null, null)
		}));
	}
}
