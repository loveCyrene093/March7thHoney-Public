using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GroupStateChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GroupStateChangeScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Hcm91cFN0YXRlQ2hhbmdlU2NOb3RpZnkucHJvdG8aFEdyb3VwU3RhdGVJ" + "bmZvLnByb3RvIkUKGEdyb3VwU3RhdGVDaGFuZ2VTY05vdGlmeRIpChBncm91" + "cF9zdGF0ZV9pbmZvGAQgASgLMg8uR3JvdXBTdGF0ZUluZm9CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { GroupStateInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GroupStateChangeScNotify), GroupStateChangeScNotify.Parser, new string[1] { "GroupStateInfo" }, null, null, null, null)
		}));
	}
}
