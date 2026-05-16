using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakePrestigeRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakePrestigeRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1UYWtlUHJlc3RpZ2VSZXdhcmRDc1JlcS5wcm90byIoChdUYWtlUHJlc3Rp" + "Z2VSZXdhcmRDc1JlcRINCgVsZXZlbBgNIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakePrestigeRewardCsReq), TakePrestigeRewardCsReq.Parser, new string[1] { "Level" }, null, null, null, null)
		}));
	}
}
