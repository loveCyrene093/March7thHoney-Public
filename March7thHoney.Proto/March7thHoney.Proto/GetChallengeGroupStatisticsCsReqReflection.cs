using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChallengeGroupStatisticsCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChallengeGroupStatisticsCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZHZXRDaGFsbGVuZ2VHcm91cFN0YXRpc3RpY3NDc1JlcS5wcm90byI0CiBH" + "ZXRDaGFsbGVuZ2VHcm91cFN0YXRpc3RpY3NDc1JlcRIQCghncm91cF9pZBgM" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChallengeGroupStatisticsCsReq), GetChallengeGroupStatisticsCsReq.Parser, new string[1] { "GroupId" }, null, null, null, null)
		}));
	}
}
