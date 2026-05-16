using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RankUpAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RankUpAvatarScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSYW5rVXBBdmF0YXJTY1JzcC5wcm90byIkChFSYW5rVXBBdmF0YXJTY1Jz" + "cBIPCgdyZXRjb2RlGAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RankUpAvatarScRsp), RankUpAvatarScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
