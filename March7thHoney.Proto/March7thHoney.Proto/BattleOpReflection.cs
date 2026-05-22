using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleOpReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleOpReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Cg5CYXR0bGVPcC5wcm90byK5AQoIQmF0dGxlT3ASFAoMdHVybl9jb3VudGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "GAEgASgNEg0KBXN0YXRlGAIgASgNEhgKEGFjdGlvbl9lbnRpdHlfaWQYAyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "KA0SGAoQdGFyZ2V0X2VudGl0eV9pZBgEIAEoDRIPCgdvcF90eXBlGAUgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "EhMKC3NraWxsX2luZGV4GAYgASgNEhkKEW9wZXJhdGlvbl9jb3VudGVyGAcg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ASgNEhMKC05PUEtGQkxMQUpQGAggASgJQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleOp), BattleOp.Parser, new string[8] { "TurnCounter", "State", "ActionEntityId", "TargetEntityId", "OpType", "SkillIndex", "OperationCounter", "NOPKFBLLAJP" }, null, null, null, null)
		}));
	}
}
