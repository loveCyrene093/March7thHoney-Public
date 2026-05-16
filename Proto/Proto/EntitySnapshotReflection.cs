using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EntitySnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EntitySnapshotReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChRFbnRpdHlTbmFwc2hvdC5wcm90bxoRSkhOS0RKTUxCSkQucHJvdG8aGE1v";
		buffer[1] = "dGlvbkluZm9TbmFwc2hvdC5wcm90bxoWUHJvcEluZm9TbmFwc2hvdC5wcm90";
		buffer[2] = "byKqAQoORW50aXR5U25hcHNob3QSEQoJZW50aXR5X2lkGAEgASgNEhMKC2lu";
		buffer[3] = "c3RhbmNlX2lkGAIgASgNEigKC21vdGlvbl9pbmZvGAMgASgLMhMuTW90aW9u";
		buffer[4] = "SW5mb1NuYXBzaG90EiUKD21hcF9vYmplY3RfdHlwZRgEIAEoDjIMLkpITktE";
		buffer[5] = "Sk1MQkpEEh8KBHByb3AYBSABKAsyES5Qcm9wSW5mb1NuYXBzaG90QhaqAhNN";
		buffer[6] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			JHNKDJMLBJDReflection.Descriptor,
			MotionInfoSnapshotReflection.Descriptor,
			PropInfoSnapshotReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EntitySnapshot), EntitySnapshot.Parser, new string[5] { "EntityId", "InstanceId", "MotionInfo", "MapObjectType", "Prop" }, null, null, null, null)
		}));
	}
}
