using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveGetFriendAssistListScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveGetFriendAssistListScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiZJZGxlTGl2ZUdldEZyaWVuZEFzc2lzdExpc3RTY1JzcC5wcm90bxoRQklC";
		buffer[1] = "TE1MREdDT0IucHJvdG8iawogSWRsZUxpdmVHZXRGcmllbmRBc3Npc3RMaXN0";
		buffer[2] = "U2NSc3ASDwoHcmV0Y29kZRgBIAEoDRITCgt0YXJnZXRfc2lkZRgOIAEoDRIh";
		buffer[3] = "CgtGTU1OQUlBS0VHTBgPIAMoCzIMLkJJQkxNTERHQ09CQhaqAhNNYXJjaDd0";
		buffer[4] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BIBLMLDGCOBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveGetFriendAssistListScRsp), IdleLiveGetFriendAssistListScRsp.Parser, new string[3] { "Retcode", "TargetSide", "FMMNAIAKEGL" }, null, null, null, null)
		}));
	}
}
