using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusInfoChangedScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusInfoChangedScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiFIZWxpb2J1c0luZm9DaGFuZ2VkU2NOb3RpZnkucHJvdG8aEURMRk9HSkdD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Q0dQLnByb3RvInkKG0hlbGlvYnVzSW5mb0NoYW5nZWRTY05vdGlmeRIhCgtI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "UEtIQkxFSkJJShgBIAMoCzIMLkRMRk9HSkdDQ0dQEhMKC0RLT0dOT0tPUEtH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "GAYgASgNEg0KBXBoYXNlGAwgASgNEhMKC0lNQk9LR0ZJQUNBGA0gASgNQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { DLFOGJGCCGPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusInfoChangedScNotify), HeliobusInfoChangedScNotify.Parser, new string[4] { "HPKHBLEJBIJ", "DKOGNOKOPKG", "Phase", "IMBOKGFIACA" }, null, null, null, null)
		}));
	}
}
