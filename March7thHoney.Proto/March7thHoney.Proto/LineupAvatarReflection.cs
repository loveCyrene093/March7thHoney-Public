using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LineupAvatarReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LineupAvatarReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChJMaW5ldXBBdmF0YXIucHJvdG8aEEF2YXRhclR5cGUucHJvdG8aD1NwQmFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SW5mby5wcm90byKDAQoMTGluZXVwQXZhdGFyEgwKBHNsb3QYBCABKA0SCgoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "aWQYBiABKA0SCgoCaHAYCSABKA0SDwoHc2F0aWV0eRgLIAEoDRIgCgthdmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "YXJfdHlwZRgMIAEoDjILLkF2YXRhclR5cGUSGgoGc3BfYmFyGA8gASgLMgou";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "U3BCYXJJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			AvatarTypeReflection.Descriptor,
			SpBarInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LineupAvatar), LineupAvatar.Parser, new string[6] { "Slot", "Id", "Hp", "Satiety", "AvatarType", "SpBar" }, null, null, null, null)
		}));
	}
}
