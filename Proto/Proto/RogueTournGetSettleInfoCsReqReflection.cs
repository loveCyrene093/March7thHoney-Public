using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournGetSettleInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournGetSettleInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZVRvdXJuR2V0U2V0dGxlSW5mb0NzUmVxLnByb3RvIi8KHFJvZ3Vl" + "VG91cm5HZXRTZXR0bGVJbmZvQ3NSZXESDwoHYXJlYV9pZBgJIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournGetSettleInfoCsReq), RogueTournGetSettleInfoCsReq.Parser, new string[1] { "AreaId" }, null, null, null, null)
		}));
	}
}
