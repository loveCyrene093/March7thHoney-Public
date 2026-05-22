using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MessageGroupStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MessageGroupStatusReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChhNZXNzYWdlR3JvdXBTdGF0dXMucHJvdG8qeQoSTWVzc2FnZUdyb3VwU3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dHVzEhYKEk1FU1NBR0VfR1JPVVBfTk9ORRAAEhcKE01FU1NBR0VfR1JPVVBf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "RE9JTkcQARIYChRNRVNTQUdFX0dST1VQX0ZJTklTSBACEhgKFE1FU1NBR0Vf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "R1JPVVBfRlJPWkVOEANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MessageGroupStatus) }, null, null));
	}
}
