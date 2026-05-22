using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAllServerPrefsDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAllServerPrefsDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRBbGxTZXJ2ZXJQcmVmc0RhdGFDc1JlcS5wcm90byIcChpHZXRBbGxT" + "ZXJ2ZXJQcmVmc0RhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAllServerPrefsDataCsReq), GetAllServerPrefsDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
