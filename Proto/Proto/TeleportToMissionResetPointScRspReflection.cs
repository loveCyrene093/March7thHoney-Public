using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TeleportToMissionResetPointScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TeleportToMissionResetPointScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiZUZWxlcG9ydFRvTWlzc2lvblJlc2V0UG9pbnRTY1JzcC5wcm90bxoQTW90";
		buffer[1] = "aW9uSW5mby5wcm90byJsCiBUZWxlcG9ydFRvTWlzc2lvblJlc2V0UG9pbnRT";
		buffer[2] = "Y1JzcBIPCgdyZXRjb2RlGAkgASgNEhsKBm1vdGlvbhgKIAEoCzILLk1vdGlv";
		buffer[3] = "bkluZm8SGgoSY2xpZW50X3Bvc192ZXJzaW9uGA0gASgNQhaqAhNNYXJjaDd0";
		buffer[4] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TeleportToMissionResetPointScRsp), TeleportToMissionResetPointScRsp.Parser, new string[3] { "Retcode", "Motion", "ClientPosVersion" }, null, null, null, null)
		}));
	}
}
