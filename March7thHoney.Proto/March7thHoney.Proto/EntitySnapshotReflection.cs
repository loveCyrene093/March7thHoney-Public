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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChRFbnRpdHlTbmFwc2hvdC5wcm90bxoRSkhOS0RKTUxCSkQucHJvdG8aGE1v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "dGlvbkluZm9TbmFwc2hvdC5wcm90bxoWUHJvcEluZm9TbmFwc2hvdC5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "byKqAQoORW50aXR5U25hcHNob3QSEQoJZW50aXR5X2lkGAEgASgNEhMKC2lu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "c3RhbmNlX2lkGAIgASgNEigKC21vdGlvbl9pbmZvGAMgASgLMhMuTW90aW9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "SW5mb1NuYXBzaG90EiUKD21hcF9vYmplY3RfdHlwZRgEIAEoDjIMLkpITktE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "Sk1MQkpEEh8KBHByb3AYBSABKAsyES5Qcm9wSW5mb1NuYXBzaG90QhaqAhNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
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
