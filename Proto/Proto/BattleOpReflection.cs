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
		buffer[0] = "Cg5CYXR0bGVPcC5wcm90byK5AQoIQmF0dGxlT3ASFAoMdHVybl9jb3VudGVy";
		buffer[1] = "GAEgASgNEg0KBXN0YXRlGAIgASgNEhgKEGFjdGlvbl9lbnRpdHlfaWQYAyAB";
		buffer[2] = "KA0SGAoQdGFyZ2V0X2VudGl0eV9pZBgEIAEoDRIPCgdvcF90eXBlGAUgASgN";
		buffer[3] = "EhMKC3NraWxsX2luZGV4GAYgASgNEhkKEW9wZXJhdGlvbl9jb3VudGVyGAcg";
		buffer[4] = "ASgNEhMKC05PUEtGQkxMQUpQGAggASgJQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[5] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleOp), BattleOp.Parser, new string[8] { "TurnCounter", "State", "ActionEntityId", "TargetEntityId", "OpType", "SkillIndex", "OperationCounter", "NOPKFBLLAJP" }, null, null, null, null)
		}));
	}
}
