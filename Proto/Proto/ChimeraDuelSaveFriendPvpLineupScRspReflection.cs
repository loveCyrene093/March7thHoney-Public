using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelSaveFriendPvpLineupScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelSaveFriendPvpLineupScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CilDaGltZXJhRHVlbFNhdmVGcmllbmRQdnBMaW5ldXBTY1JzcC5wcm90bxoR";
		buffer[1] = "REtER0dHQ0RBR00ucHJvdG8iYgojQ2hpbWVyYUR1ZWxTYXZlRnJpZW5kUHZw";
		buffer[2] = "TGluZXVwU2NSc3ASHAoGbGluZXVwGAEgASgLMgwuREtER0dHQ0RBR00SDAoE";
		buffer[3] = "c2xvdBgDIAEoDRIPCgdyZXRjb2RlGAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[4] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { DKDGGGCDAGMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelSaveFriendPvpLineupScRsp), ChimeraDuelSaveFriendPvpLineupScRsp.Parser, new string[3] { "Lineup", "Slot", "Retcode" }, null, null, null, null)
		}));
	}
}
