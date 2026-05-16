using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneEntityInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneEntityInfoReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 0) = "ChVTY2VuZUVudGl0eUluZm8ucHJvdG8aEE1vdGlvbkluZm8ucHJvdG8aFFNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 1) = "ZW5lQWN0b3JJbmZvLnByb3RvGhJTY2VuZU5wY0luZm8ucHJvdG8aGVNjZW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 2) = "TnBjTW9uc3RlckluZm8ucHJvdG8aE1NjZW5lUHJvcEluZm8ucHJvdG8aGVNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 3) = "ZW5lU3VtbW9uVW5pdEluZm8ucHJvdG8iqAIKD1NjZW5lRW50aXR5SW5mbxIP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 4) = "CgdpbnN0X2lkGAQgASgNEhsKBm1vdGlvbhgMIAEoCzILLk1vdGlvbkluZm8S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 5) = "EAoIZ3JvdXBfaWQYDSABKA0SEQoJZW50aXR5X2lkGA4gASgNEiAKBWFjdG9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 6) = "GAEgASgLMg8uU2NlbmVBY3RvckluZm9IABIeCgRwcm9wGAMgASgLMg4uU2Nl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 7) = "bmVQcm9wSW5mb0gAEhwKA25wYxgIIAEoCzINLlNjZW5lTnBjSW5mb0gAEisK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 8) = "C25wY19tb25zdGVyGAkgASgLMhQuU2NlbmVOcGNNb25zdGVySW5mb0gAEisK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 9) = "C3N1bW1vbl91bml0GAsgASgLMhQuU2NlbmVTdW1tb25Vbml0SW5mb0gAQggK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 10) = "BmVudGl0eUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray11<string>, string>(in buffer, 11))), new FileDescriptor[6]
		{
			MotionInfoReflection.Descriptor,
			SceneActorInfoReflection.Descriptor,
			SceneNpcInfoReflection.Descriptor,
			SceneNpcMonsterInfoReflection.Descriptor,
			ScenePropInfoReflection.Descriptor,
			SceneSummonUnitInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityInfo), SceneEntityInfo.Parser, new string[9] { "InstId", "Motion", "GroupId", "EntityId", "Actor", "Prop", "Npc", "NpcMonster", "SummonUnit" }, new string[1] { "Entity" }, null, null, null)
		}));
	}
}
