using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HIBBBJBENHCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HIBBBJBENHCReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFISUJCQkpCRU5IQy5wcm90bxoQTW90aW9uSW5mby5wcm90bxoMVmVjdG9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "LnByb3RvInIKC0hJQkJCSkJFTkhDEhsKBm1vdGlvbhgLIAEoCzILLk1vdGlv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "bkluZm8SEwoLQklBR0lGSUtETkEYDCABKA0SHAoLQkxMTERDTU9BQUkYDSAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KAsyBy5WZWN0b3ISEwoLUElKTUtITURIQUUYDiABKAhCFqoCE01hcmNoN3Ro";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			MotionInfoReflection.Descriptor,
			VectorReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HIBBBJBENHC), HIBBBJBENHC.Parser, new string[4] { "Motion", "BIAGIFIKDNA", "BLLLDCMOAAI", "PIJMKHMDHAE" }, null, null, null, null)
		}));
	}
}
