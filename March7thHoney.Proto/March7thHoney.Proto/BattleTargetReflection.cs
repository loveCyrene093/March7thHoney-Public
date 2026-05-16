using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleTargetReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleTargetReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJCYXR0bGVUYXJnZXQucHJvdG8iRAoMQmF0dGxlVGFyZ2V0EgoKAmlkGAEg" + "ASgNEhAKCHByb2dyZXNzGAIgASgNEhYKDnRvdGFsX3Byb2dyZXNzGAMgASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleTarget), BattleTarget.Parser, new string[3] { "Id", "Progress", "TotalProgress" }, null, null, null, null)
		}));
	}
}
