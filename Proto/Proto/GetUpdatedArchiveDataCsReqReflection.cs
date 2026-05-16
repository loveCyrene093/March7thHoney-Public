using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetUpdatedArchiveDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetUpdatedArchiveDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRVcGRhdGVkQXJjaGl2ZURhdGFDc1JlcS5wcm90byIcChpHZXRVcGRh" + "dGVkQXJjaGl2ZURhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetUpdatedArchiveDataCsReq), GetUpdatedArchiveDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
