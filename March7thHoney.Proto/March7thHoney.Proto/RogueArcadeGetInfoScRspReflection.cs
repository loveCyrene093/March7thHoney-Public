using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueArcadeGetInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueArcadeGetInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Sb2d1ZUFyY2FkZUdldEluZm9TY1JzcC5wcm90byI7ChdSb2d1ZUFyY2Fk" + "ZUdldEluZm9TY1JzcBIPCgdyZXRjb2RlGAMgASgNEg8KB3Jvb21faWQYCCAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueArcadeGetInfoScRsp), RogueArcadeGetInfoScRsp.Parser, new string[2] { "Retcode", "RoomId" }, null, null, null, null)
		}));
	}
}
