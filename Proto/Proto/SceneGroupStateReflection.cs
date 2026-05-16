using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneGroupStateReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneGroupStateReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVTY2VuZUdyb3VwU3RhdGUucHJvdG8iRgoPU2NlbmVHcm91cFN0YXRlEhAK" + "CGdyb3VwX2lkGAQgASgNEg0KBXN0YXRlGAUgASgNEhIKCmlzX2RlZmF1bHQY" + "CiABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneGroupState), SceneGroupState.Parser, new string[3] { "GroupId", "State", "IsDefault" }, null, null, null, null)
		}));
	}
}
