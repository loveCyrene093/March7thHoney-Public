using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetLocalLegendDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetLocalLegendDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRMb2NhbExlZ2VuZERhdGFDc1JlcS5wcm90byIZChdHZXRMb2NhbExl" + "Z2VuZERhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetLocalLegendDataCsReq), GetLocalLegendDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
