using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetActivityHotDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetActivityHotDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRBY3Rpdml0eUhvdERhdGFDc1JlcS5wcm90byIZChdHZXRBY3Rpdml0" + "eUhvdERhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetActivityHotDataCsReq), GetActivityHotDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
