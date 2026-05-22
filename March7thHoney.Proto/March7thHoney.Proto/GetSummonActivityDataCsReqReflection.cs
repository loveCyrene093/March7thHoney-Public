using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSummonActivityDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSummonActivityDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRTdW1tb25BY3Rpdml0eURhdGFDc1JlcS5wcm90byIcChpHZXRTdW1t" + "b25BY3Rpdml0eURhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSummonActivityDataCsReq), GetSummonActivityDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
