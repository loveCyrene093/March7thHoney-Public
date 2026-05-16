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
		buffer[0] = "ChFISUJCQkpCRU5IQy5wcm90bxoQTW90aW9uSW5mby5wcm90bxoMVmVjdG9y";
		buffer[1] = "LnByb3RvInIKC0hJQkJCSkJFTkhDEhsKBm1vdGlvbhgLIAEoCzILLk1vdGlv";
		buffer[2] = "bkluZm8SEwoLQklBR0lGSUtETkEYDCABKA0SHAoLQkxMTERDTU9BQUkYDSAD";
		buffer[3] = "KAsyBy5WZWN0b3ISEwoLUElKTUtITURIQUUYDiABKAhCFqoCE01hcmNoN3Ro";
		buffer[4] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MotionInfoReflection.Descriptor,
			VectorReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HIBBBJBENHC), HIBBBJBENHC.Parser, new string[4] { "Motion", "BIAGIFIKDNA", "BLLLDCMOAAI", "PIJMKHMDHAE" }, null, null, null, null)
		}));
	}
}
