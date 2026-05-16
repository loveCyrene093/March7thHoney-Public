using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RevcMsgScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RevcMsgScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChVSZXZjTXNnU2NOb3RpZnkucHJvdG8aFUNoYXRNZXNzYWdlRGF0YS5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bxoOQ2hhdFR5cGUucHJvdG8icAoPUmV2Y01zZ1NjTm90aWZ5EhwKCWNoYXRf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dHlwZRgFIAEoDjIJLkNoYXRUeXBlEhIKCnNvdXJjZV91aWQYCSABKA0SKwoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cmVjdl9tZXNzYWdlX2RhdGEYDyABKAsyEC5DaGF0TWVzc2FnZURhdGFCFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ChatMessageDataReflection.Descriptor,
			ChatTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RevcMsgScNotify), RevcMsgScNotify.Parser, new string[3] { "ChatType", "SourceUid", "RecvMessageData" }, null, null, null, null)
		}));
	}
}
