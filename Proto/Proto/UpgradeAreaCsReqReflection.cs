using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpgradeAreaCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpgradeAreaCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZVcGdyYWRlQXJlYUNzUmVxLnByb3RvIjIKEFVwZ3JhZGVBcmVhQ3NSZXES" + "DwoHYXJlYV9pZBgFIAEoDRINCgVsZXZlbBgHIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpgradeAreaCsReq), UpgradeAreaCsReq.Parser, new string[2] { "AreaId", "Level" }, null, null, null, null)
		}));
	}
}
