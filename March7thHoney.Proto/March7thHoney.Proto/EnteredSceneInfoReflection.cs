using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnteredSceneInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnteredSceneInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZFbnRlcmVkU2NlbmVJbmZvLnByb3RvIjYKEEVudGVyZWRTY2VuZUluZm8S" + "EAoIcGxhbmVfaWQYByABKA0SEAoIZmxvb3JfaWQYCCABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnteredSceneInfo), EnteredSceneInfo.Parser, new string[2] { "PlaneId", "FloorId" }, null, null, null, null)
		}));
	}
}
