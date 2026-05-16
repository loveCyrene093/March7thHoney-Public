using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAvatarDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAvatarDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhHZXRBdmF0YXJEYXRhQ3NSZXEucHJvdG8iRQoSR2V0QXZhdGFyRGF0YUNz" + "UmVxEhsKE2Jhc2VfYXZhdGFyX2lkX2xpc3QYAiADKA0SEgoKaXNfZ2V0X2Fs" + "bBgDIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAvatarDataCsReq), GetAvatarDataCsReq.Parser, new string[2] { "BaseAvatarIdList", "IsGetAll" }, null, null, null, null)
		}));
	}
}
