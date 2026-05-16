using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearGetPinRelicCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearGetPinRelicCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZWxpY1NtYXJ0V2VhckdldFBpblJlbGljQ3NSZXEucHJvdG8iMwoeUmVs" + "aWNTbWFydFdlYXJHZXRQaW5SZWxpY0NzUmVxEhEKCWF2YXRhcl9pZBgKIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearGetPinRelicCsReq), RelicSmartWearGetPinRelicCsReq.Parser, new string[1] { "AvatarId" }, null, null, null, null)
		}));
	}
}
