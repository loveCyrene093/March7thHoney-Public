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
		buffer[0] = "ChVSZXZjTXNnU2NOb3RpZnkucHJvdG8aFUNoYXRNZXNzYWdlRGF0YS5wcm90";
		buffer[1] = "bxoOQ2hhdFR5cGUucHJvdG8icAoPUmV2Y01zZ1NjTm90aWZ5EhwKCWNoYXRf";
		buffer[2] = "dHlwZRgFIAEoDjIJLkNoYXRUeXBlEhIKCnNvdXJjZV91aWQYCSABKA0SKwoR";
		buffer[3] = "cmVjdl9tZXNzYWdlX2RhdGEYDyABKAsyEC5DaGF0TWVzc2FnZURhdGFCFqoC";
		buffer[4] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ChatMessageDataReflection.Descriptor,
			ChatTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RevcMsgScNotify), RevcMsgScNotify.Parser, new string[3] { "ChatType", "SourceUid", "RecvMessageData" }, null, null, null, null)
		}));
	}
}
