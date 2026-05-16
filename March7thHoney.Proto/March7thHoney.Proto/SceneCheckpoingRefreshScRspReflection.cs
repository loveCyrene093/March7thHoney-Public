using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneCheckpoingRefreshScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneCheckpoingRefreshScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTY2VuZUNoZWNrcG9pbmdSZWZyZXNoU2NSc3AucHJvdG8iLgobU2NlbmVD" + "aGVja3BvaW5nUmVmcmVzaFNjUnNwEg8KB3JldGNvZGUYDCABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneCheckpoingRefreshScRsp), SceneCheckpoingRefreshScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
