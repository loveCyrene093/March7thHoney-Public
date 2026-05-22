using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SendMsgCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SendMsgCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChJTZW5kTXNnQ3NSZXEucHJvdG8aDkNoYXRUeXBlLnByb3RvGhVNZXNzYWdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Q2hhdERhdGEucHJvdG8iagoMU2VuZE1zZ0NzUmVxEicKDW1lc3NhZ2VfZGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "YXMYCCABKAsyEC5NZXNzYWdlQ2hhdERhdGESEwoLdGFyZ2V0X2xpc3QYCSAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KA0SHAoJY2hhdF90eXBlGA0gASgOMgkuQ2hhdFR5cGVCFqoCE01hcmNoN3Ro";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ChatTypeReflection.Descriptor,
			MessageChatDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SendMsgCsReq), SendMsgCsReq.Parser, new string[3] { "MessageDatas", "TargetList", "ChatType" }, null, null, null, null)
		}));
	}
}
