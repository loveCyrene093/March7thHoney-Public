using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TechTreeChangeNodeStateCsRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TechTreeChangeNodeStateCsRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJUZWNoVHJlZUNoYW5nZU5vZGVTdGF0ZUNzUnNwLnByb3RvGhFKREtKUEZH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Sk9CSS5wcm90byJjChxUZWNoVHJlZUNoYW5nZU5vZGVTdGF0ZUNzUnNwEg8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "B3JldGNvZGUYAyABKA0SHQoHb3BfdHlwZRgFIAEoDjIMLkpES0pQRkdKT0JJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "EhMKC05MR05BS0tDREdPGAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { JDKJPFGJOBIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TechTreeChangeNodeStateCsRsp), TechTreeChangeNodeStateCsRsp.Parser, new string[3] { "Retcode", "OpType", "NLGNAKKCDGO" }, null, null, null, null)
		}));
	}
}
