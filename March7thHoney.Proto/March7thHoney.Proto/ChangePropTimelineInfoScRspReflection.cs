using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChangePropTimelineInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChangePropTimelineInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDaGFuZ2VQcm9wVGltZWxpbmVJbmZvU2NSc3AucHJvdG8iRgobQ2hhbmdl" + "UHJvcFRpbWVsaW5lSW5mb1NjUnNwEhYKDnByb3BfZW50aXR5X2lkGAMgASgN" + "Eg8KB3JldGNvZGUYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChangePropTimelineInfoScRsp), ChangePropTimelineInfoScRsp.Parser, new string[2] { "PropEntityId", "Retcode" }, null, null, null, null)
		}));
	}
}
