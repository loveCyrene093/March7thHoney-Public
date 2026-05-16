using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdChatTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdChatTypeReflection()
	{
		InlineArray13<string> buffer = default(InlineArray13<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 0) = "ChFDbWRDaGF0VHlwZS5wcm90byqIBAoLQ21kQ2hhdFR5cGUSGwoXSERDQUhC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 1) = "RkJPRE9fUENQREhFTFBLRU0QABIdChhDbWRHZXRDaGF0RW1vamlMaXN0U2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 2) = "c3AQ1h4SIgodQ21kR2V0UHJpdmF0ZUNoYXRIaXN0b3J5Q3NSZXEQyh4SIgod";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 3) = "Q21kR2V0UHJpdmF0ZUNoYXRIaXN0b3J5U2NSc3AQzh4SHQoYQ21kR2V0Q2hh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 4) = "dEVtb2ppTGlzdENzUmVxEPseEhMKDkNtZEhBQkVJUEpHUE5KEJsfEhoKFUNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 5) = "ZE1hcmtDaGF0RW1vamlTY1JzcBC9HhIXChJDbWRSZXZjTXNnU2NOb3RpZnkQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 6) = "mh8SHQoYQ21kR2V0TG9naW5DaGF0SW5mb1NjUnNwEOIeEh0KGENtZEdldExv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 7) = "Z2luQ2hhdEluZm9Dc1JlcRDAHhIfChpDbWRCYXRjaE1hcmtDaGF0RW1vamlD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 8) = "c1JlcRCGHxIUCg9DbWRTZW5kTXNnU2NSc3AQxh4SHwoaQ21kQmF0Y2hNYXJr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 9) = "Q2hhdEVtb2ppU2NSc3AQ4R4SIQocQ21kR2V0Q2hhdEZyaWVuZEhpc3RvcnlD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 10) = "c1JlcRDFHhIUCg9DbWRTZW5kTXNnQ3NSZXEQlx8SIQocQ21kR2V0Q2hhdEZy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 11) = "aWVuZEhpc3RvcnlTY1JzcBCeHxIaChVDbWRNYXJrQ2hhdEVtb2ppQ3NSZXEQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 12) = "4x5CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray13<string>, string>(in buffer, 13))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdChatType) }, null, null));
	}
}
