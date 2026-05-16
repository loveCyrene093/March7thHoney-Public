using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueWorkbenchGetInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueWorkbenchGetInfoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiBSb2d1ZVdvcmtiZW5jaEdldEluZm9TY1JzcC5wcm90bxoRQ0dLQkVCQ0NE";
		buffer[1] = "R0YucHJvdG8isgEKGlJvZ3VlV29ya2JlbmNoR2V0SW5mb1NjUnNwEg8KB3Jl";
		buffer[2] = "dGNvZGUYAiABKA0SQQoLREtPQVBESkdMT0EYDCADKAsyLC5Sb2d1ZVdvcmti";
		buffer[3] = "ZW5jaEdldEluZm9TY1JzcC5ES09BUERKR0xPQUVudHJ5GkAKEERLT0FQREpH";
		buffer[4] = "TE9BRW50cnkSCwoDa2V5GAEgASgNEhsKBXZhbHVlGAIgASgLMgwuQ0dLQkVC";
		buffer[5] = "Q0NER0Y6AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { CGKBEBCCDGFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueWorkbenchGetInfoScRsp), RogueWorkbenchGetInfoScRsp.Parser, new string[2] { "Retcode", "DKOAPDJGLOA" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
