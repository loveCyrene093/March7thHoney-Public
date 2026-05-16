using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateMovieRacingDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateMovieRacingDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBVcGRhdGVNb3ZpZVJhY2luZ0RhdGFDc1JlcS5wcm90bxoRQk5JR0lBSk9Q" + "R0MucHJvdG8iPwoaVXBkYXRlTW92aWVSYWNpbmdEYXRhQ3NSZXESIQoLSU1D" + "RUtGT09LSEMYDiABKAsyDC5CTklHSUFKT1BHQ0IWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BNIGIAJOPGCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateMovieRacingDataCsReq), UpdateMovieRacingDataCsReq.Parser, new string[1] { "IMCEKFOOKHC" }, null, null, null, null)
		}));
	}
}
