using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MPGIOHDMFCGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MPGIOHDMFCGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNUEdJT0hETUZDRy5wcm90byJhCgtNUEdJT0hETUZDRxITCgtNRUFKQUVC" + "REFPSRgBIAEoDRITCgtJQU1DUEtNTkFOTxgEIAEoDRITCgtFUEZPSUJITERB" + "TxgLIAEoDRITCgtQQU5GSVBIQUdQQhgPIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MPGIOHDMFCG), MPGIOHDMFCG.Parser, new string[4] { "MEAJAEBDAOI", "IAMCPKMNANO", "EPFOIBHLDAO", "PANFIPHAGPB" }, null, null, null, null)
		}));
	}
}
