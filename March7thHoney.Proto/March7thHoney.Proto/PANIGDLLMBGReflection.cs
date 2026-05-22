using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PANIGDLLMBGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PANIGDLLMBGReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFQQU5JR0RMTE1CRy5wcm90bxoXRGlzcGxheUF2YXRhckluZm8ucHJvdG8i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "lwEKC1BBTklHRExMTUJHEhsKE3BlYWtfYXZhdGFyX2lkX2xpc3QYAiADKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "DwoHcGVha19pZBgIIAEoDRITCgtjeWNsZXNfdXNlZBgJIAEoDRInCgthdmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "YXJfbGlzdBgMIAMoCzISLkRpc3BsYXlBdmF0YXJJbmZvEhwKFGZpbmlzaGVk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "X3RhcmdldF9saXN0GA0gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { DisplayAvatarInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PANIGDLLMBG), PANIGDLLMBG.Parser, new string[5] { "PeakAvatarIdList", "PeakId", "CyclesUsed", "AvatarList", "FinishedTargetList" }, null, null, null, null)
		}));
	}
}
