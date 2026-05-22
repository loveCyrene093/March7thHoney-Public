using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnSignScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnSignScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChtQbGF5ZXJSZXR1cm5TaWduU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "GhFLRU9MRUhITEhITS5wcm90byJrChVQbGF5ZXJSZXR1cm5TaWduU2NSc3AS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "DwoHcmV0Y29kZRgKIAEoDRIeCgtFQkNBRUZPTkRKQxgNIAMoCzIJLkl0ZW1M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "aXN0EiEKC0RNSEdEUEJBQUxOGA8gAygLMgwuS0VPTEVISExISE1CFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			KEOLEHHLHHMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnSignScRsp), PlayerReturnSignScRsp.Parser, new string[3] { "Retcode", "EBCAEFONDJC", "DMHGDPBAALN" }, null, null, null, null)
		}));
	}
}
