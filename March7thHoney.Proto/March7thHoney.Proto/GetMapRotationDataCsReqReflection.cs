using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMapRotationDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMapRotationDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRNYXBSb3RhdGlvbkRhdGFDc1JlcS5wcm90byIZChdHZXRNYXBSb3Rh" + "dGlvbkRhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMapRotationDataCsReq), GetMapRotationDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
