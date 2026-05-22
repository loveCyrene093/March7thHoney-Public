using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeActiveActivityRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeActiveActivityRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNUYWtlQWN0aXZlQWN0aXZpdHlSZXdhcmRDc1JlcS5wcm90byIrCh1UYWtl" + "QWN0aXZlQWN0aXZpdHlSZXdhcmRDc1JlcRIKCgJpZBgIIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeActiveActivityRewardCsReq), TakeActiveActivityRewardCsReq.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
