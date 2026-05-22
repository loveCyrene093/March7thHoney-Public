using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCurSceneInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCurSceneInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRDdXJTY2VuZUluZm9TY1JzcC5wcm90bxoPU2NlbmVJbmZvLnByb3Rv" + "IkIKFEdldEN1clNjZW5lSW5mb1NjUnNwEhkKBXNjZW5lGAMgASgLMgouU2Nl" + "bmVJbmZvEg8KB3JldGNvZGUYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[1] { SceneInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurSceneInfoScRsp), GetCurSceneInfoScRsp.Parser, new string[2] { "Scene", "Retcode" }, null, null, null, null)
		}));
	}
}
