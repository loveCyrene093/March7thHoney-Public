using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CocoonSweepScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CocoonSweepScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChZDb2Nvb25Td2VlcFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJ7ChBD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "b2Nvb25Td2VlcFNjUnNwEhEKCWNvY29vbl9pZBgBIAEoDRIPCgdyZXRjb2Rl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "GAQgASgNEhwKCWRyb3BfZGF0YRgFIAEoCzIJLkl0ZW1MaXN0EiUKEm11bHRp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cGxlX2Ryb3BfZGF0YRgMIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CocoonSweepScRsp), CocoonSweepScRsp.Parser, new string[4] { "CocoonId", "Retcode", "DropData", "MultipleDropData" }, null, null, null, null)
		}));
	}
}
