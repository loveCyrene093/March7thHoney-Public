using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterSceneByServerScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterSceneByServerScNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiBFbnRlclNjZW5lQnlTZXJ2ZXJTY05vdGlmeS5wcm90bxoWRW50ZXJTY2Vu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "ZVJlYXNvbi5wcm90bxoQTGluZXVwSW5mby5wcm90bxoPU2NlbmVJbmZvLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "b3RvIncKGkVudGVyU2NlbmVCeVNlcnZlclNjTm90aWZ5EhsKBmxpbmV1cBgD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "IAEoCzILLkxpbmV1cEluZm8SGQoFc2NlbmUYCSABKAsyCi5TY2VuZUluZm8S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "IQoGcmVhc29uGAwgASgOMhEuRW50ZXJTY2VuZVJlYXNvbkIWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[3]
		{
			EnterSceneReasonReflection.Descriptor,
			LineupInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterSceneByServerScNotify), EnterSceneByServerScNotify.Parser, new string[3] { "Lineup", "Scene", "Reason" }, null, null, null, null)
		}));
	}
}
