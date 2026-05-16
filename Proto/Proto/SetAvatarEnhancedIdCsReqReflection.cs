using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetAvatarEnhancedIdCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetAvatarEnhancedIdCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TZXRBdmF0YXJFbmhhbmNlZElkQ3NSZXEucHJvdG8iQgoYU2V0QXZhdGFy" + "RW5oYW5jZWRJZENzUmVxEhMKC2VuaGFuY2VkX2lkGAEgASgNEhEKCWF2YXRh" + "cl9pZBgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetAvatarEnhancedIdCsReq), SetAvatarEnhancedIdCsReq.Parser, new string[2] { "EnhancedId", "AvatarId" }, null, null, null, null)
		}));
	}
}
