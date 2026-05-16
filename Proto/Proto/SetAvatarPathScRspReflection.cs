using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetAvatarPathScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetAvatarPathScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRBdmF0YXJQYXRoU2NSc3AucHJvdG8aGU11bHRpUGF0aEF2YXRhclR5" + "cGUucHJvdG8iTgoSU2V0QXZhdGFyUGF0aFNjUnNwEg8KB3JldGNvZGUYCSAB" + "KA0SJwoJYXZhdGFyX2lkGAwgASgOMhQuTXVsdGlQYXRoQXZhdGFyVHlwZUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MultiPathAvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetAvatarPathScRsp), SetAvatarPathScRsp.Parser, new string[2] { "Retcode", "AvatarId" }, null, null, null, null)
		}));
	}
}
