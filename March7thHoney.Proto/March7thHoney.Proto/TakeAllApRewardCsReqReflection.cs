using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeAllApRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeAllApRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpUYWtlQWxsQXBSZXdhcmRDc1JlcS5wcm90byIWChRUYWtlQWxsQXBSZXdh" + "cmRDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeAllApRewardCsReq), TakeAllApRewardCsReq.Parser, null, null, null, null, null)
		}));
	}
}
