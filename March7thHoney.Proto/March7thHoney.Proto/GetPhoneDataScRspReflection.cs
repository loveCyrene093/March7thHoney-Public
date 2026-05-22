using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPhoneDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPhoneDataScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChdHZXRQaG9uZURhdGFTY1JzcC5wcm90byLBAQoRR2V0UGhvbmVEYXRhU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "c3ASDwoHcmV0Y29kZRgBIAEoDRIaChJvd25lZF9waG9uZV90aGVtZXMYAiAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "KA0SFgoOY3VyX3Bob25lX2Nhc2UYAyABKA0SFwoPY3VyX3Bob25lX3RoZW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "GAUgASgNEhkKEW93bmVkX3Bob25lX2Nhc2VzGAcgAygNEhoKEm93bmVkX2No";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "YXRfYnViYmxlcxgIIAMoDRIXCg9jdXJfY2hhdF9idWJibGUYCSABKA1CFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPhoneDataScRsp), GetPhoneDataScRsp.Parser, new string[7] { "Retcode", "OwnedPhoneThemes", "CurPhoneCase", "CurPhoneTheme", "OwnedPhoneCases", "OwnedChatBubbles", "CurChatBubble" }, null, null, null, null)
		}));
	}
}
