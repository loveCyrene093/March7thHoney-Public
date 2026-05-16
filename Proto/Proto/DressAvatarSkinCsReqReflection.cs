using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DressAvatarSkinCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DressAvatarSkinCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpEcmVzc0F2YXRhclNraW5Dc1JlcS5wcm90byI6ChREcmVzc0F2YXRhclNr" + "aW5Dc1JlcRIRCglhdmF0YXJfaWQYAiABKA0SDwoHc2tpbl9pZBgIIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DressAvatarSkinCsReq), DressAvatarSkinCsReq.Parser, new string[2] { "AvatarId", "SkinId" }, null, null, null, null)
		}));
	}
}
