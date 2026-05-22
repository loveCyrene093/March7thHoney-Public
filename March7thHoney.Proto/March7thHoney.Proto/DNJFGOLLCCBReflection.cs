using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DNJFGOLLCCBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DNJFGOLLCCBReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFETkpGR09MTENDQi5wcm90byKgAQoLRE5KRkdPTExDQ0ISEwoLTEdNTktJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TEFCTkwYASABKAkSEwoLQ0pCT0ROS0RGQUcYAiABKAkSEwoLQUpMR0pLTUVG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "SkwYAyABKAkSEwoLR05DUEZGSEJJUE4YBCABKAkSEwoLQ09PRkhJR0hKRE4Y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "BSABKAkSEwoLTk1CTkxQT0hKQ00YBiABKAkSEwoLQ0ROQkVMSUFKRk4YByAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "KAlCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DNJFGOLLCCB), DNJFGOLLCCB.Parser, new string[7] { "LGMNKILABNL", "CJBODNKDFAG", "AJLGJKMEFJL", "GNCPFFHBIPN", "COOFHIGHJDN", "NMBNLPOHJCM", "CDNBELIAJFN" }, null, null, null, null)
		}));
	}
}
