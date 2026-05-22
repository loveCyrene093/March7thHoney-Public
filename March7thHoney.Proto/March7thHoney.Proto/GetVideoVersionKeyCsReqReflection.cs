using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetVideoVersionKeyCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetVideoVersionKeyCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRWaWRlb1ZlcnNpb25LZXlDc1JlcS5wcm90byIZChdHZXRWaWRlb1Zl" + "cnNpb25LZXlDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetVideoVersionKeyCsReq), GetVideoVersionKeyCsReq.Parser, null, null, null, null, null)
		}));
	}
}
