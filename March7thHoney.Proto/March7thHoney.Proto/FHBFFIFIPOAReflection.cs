using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FHBFFIFIPOAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FHBFFIFIPOAReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFGSEJGRklGSVBPQS5wcm90bxoRQU1ETUtGR09BUE8ucHJvdG8aFkx1Y2t5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "S29pSW5mb0xpc3QucHJvdG8iqAEKC0ZIQkZGSUZJUE9BEhIKCmJlZ2luX3Rp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "bWUYASABKAQSEAoIZW5kX3RpbWUYAiABKAQSEwoLR0VQSU1BRU9OSUYYAyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "KA0SEwoLRU9HSE1PSEJMTk4YCiABKAQSJgoLSU1OUEZKSUJKRkUYDSADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ES5MdWNreUtvaUluZm9MaXN0EiEKC0FIQkZBQU1OS05PGA4gAygLMgwuQU1E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "TUtGR09BUE9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			AMDMKFGOAPOReflection.Descriptor,
			LuckyKoiInfoListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FHBFFIFIPOA), FHBFFIFIPOA.Parser, new string[6] { "BeginTime", "EndTime", "GEPIMAEONIF", "EOGHMOHBLNN", "IMNPFJIBJFE", "AHBFAAMNKNO" }, null, null, null, null)
		}));
	}
}
