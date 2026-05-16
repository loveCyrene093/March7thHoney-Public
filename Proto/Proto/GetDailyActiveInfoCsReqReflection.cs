using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetDailyActiveInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetDailyActiveInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXREYWlseUFjdGl2ZUluZm9Dc1JlcS5wcm90byIZChdHZXREYWlseUFj" + "dGl2ZUluZm9Dc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetDailyActiveInfoCsReq), GetDailyActiveInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
