using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendAssistListScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendAssistListScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5HZXRGcmllbmRBc3Npc3RMaXN0U2NSc3AucHJvdG8aFlBsYXllckFzc2lz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dEluZm8ucHJvdG8iaAoYR2V0RnJpZW5kQXNzaXN0TGlzdFNjUnNwEg8KB3Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dGNvZGUYByABKA0SEwoLdGFyZ2V0X3NpZGUYCiABKA0SJgoLYXNzaXN0X2xp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "c3QYDCADKAsyES5QbGF5ZXJBc3Npc3RJbmZvQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { PlayerAssistInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendAssistListScRsp), GetFriendAssistListScRsp.Parser, new string[3] { "Retcode", "TargetSide", "AssistList" }, null, null, null, null)
		}));
	}
}
