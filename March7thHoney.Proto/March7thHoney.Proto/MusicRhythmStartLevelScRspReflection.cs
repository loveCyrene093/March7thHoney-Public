using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MusicRhythmStartLevelScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MusicRhythmStartLevelScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBNdXNpY1JoeXRobVN0YXJ0TGV2ZWxTY1JzcC5wcm90byJUChpNdXNpY1Jo" + "eXRobVN0YXJ0TGV2ZWxTY1JzcBIQCghsZXZlbF9pZBgCIAEoDRIPCgdyZXRj" + "b2RlGAYgASgNEhMKC01ESUxESk1QTkdIGAggASgJQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmStartLevelScRsp), MusicRhythmStartLevelScRsp.Parser, new string[3] { "LevelId", "Retcode", "MDILDJMPNGH" }, null, null, null, null)
		}));
	}
}
