using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetAvatarPathCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetAvatarPathCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRBdmF0YXJQYXRoQ3NSZXEucHJvdG8aGU11bHRpUGF0aEF2YXRhclR5" + "cGUucHJvdG8iPQoSU2V0QXZhdGFyUGF0aENzUmVxEicKCWF2YXRhcl9pZBgM" + "IAEoDjIULk11bHRpUGF0aEF2YXRhclR5cGVCFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { MultiPathAvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetAvatarPathCsReq), SetAvatarPathCsReq.Parser, new string[1] { "AvatarId" }, null, null, null, null)
		}));
	}
}
