using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSceneMapInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSceneMapInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRTY2VuZU1hcEluZm9TY1JzcC5wcm90bxoSU2NlbmVNYXBJbmZvLnBy" + "b3RvIk4KFEdldFNjZW5lTWFwSW5mb1NjUnNwEiUKDnNjZW5lX21hcF9pbmZv" + "GAcgAygLMg0uU2NlbmVNYXBJbmZvEg8KB3JldGNvZGUYCyABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { SceneMapInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSceneMapInfoScRsp), GetSceneMapInfoScRsp.Parser, new string[2] { "SceneMapInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
