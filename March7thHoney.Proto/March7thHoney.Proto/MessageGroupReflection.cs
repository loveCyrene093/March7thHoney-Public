using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MessageGroupReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MessageGroupReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChJNZXNzYWdlR3JvdXAucHJvdG8aGE1lc3NhZ2VHcm91cFN0YXR1cy5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "bxoUTWVzc2FnZVNlY3Rpb24ucHJvdG8ioAEKDE1lc3NhZ2VHcm91cBIjCgZz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "dGF0dXMYBSABKA4yEy5NZXNzYWdlR3JvdXBTdGF0dXMSCgoCaWQYCyABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "FAoMcmVmcmVzaF90aW1lGAwgASgDEi0KFG1lc3NhZ2Vfc2VjdGlvbl9saXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "GA4gAygLMg8uTWVzc2FnZVNlY3Rpb24SGgoSbWVzc2FnZV9zZWN0aW9uX2lk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			MessageGroupStatusReflection.Descriptor,
			MessageSectionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MessageGroup), MessageGroup.Parser, new string[5] { "Status", "Id", "RefreshTime", "MessageSectionList", "MessageSectionId" }, null, null, null, null)
		}));
	}
}
