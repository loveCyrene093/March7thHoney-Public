using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TravelBrochureGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TravelBrochureGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBUcmF2ZWxCcm9jaHVyZUdldERhdGFDc1JlcS5wcm90byIcChpUcmF2ZWxC" + "cm9jaHVyZUdldERhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureGetDataCsReq), TravelBrochureGetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
