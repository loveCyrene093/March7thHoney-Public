using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockAvatarPathCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockAvatarPathCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtVbmxvY2tBdmF0YXJQYXRoQ3NSZXEucHJvdG8aGU11bHRpUGF0aEF2YXRh" + "clR5cGUucHJvdG8iQAoVVW5sb2NrQXZhdGFyUGF0aENzUmVxEicKCWF2YXRh" + "cl9pZBgMIAEoDjIULk11bHRpUGF0aEF2YXRhclR5cGVCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { MultiPathAvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockAvatarPathCsReq), UnlockAvatarPathCsReq.Parser, new string[1] { "AvatarId" }, null, null, null, null)
		}));
	}
}
