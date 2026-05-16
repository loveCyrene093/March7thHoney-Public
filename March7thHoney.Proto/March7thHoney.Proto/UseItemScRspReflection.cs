using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UseItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UseItemScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChJVc2VJdGVtU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3RvIqIBCgxVc2VJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "dGVtU2NSc3ASDwoHcmV0Y29kZRgDIAEoDRIWCg51c2VfaXRlbV9jb3VudBgF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "IAEoDRIeCgtyZXR1cm5fZGF0YRgGIAEoCzIJLkl0ZW1MaXN0EhMKC3VzZV9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "dGVtX2lkGAogASgNEhIKCmZvcm11bGFfaWQYCyABKA0SIAoYbW9udGhfY2Fy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ZF9vdXRfZGF0ZV90aW1lGA4gASgEQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UseItemScRsp), UseItemScRsp.Parser, new string[6] { "Retcode", "UseItemCount", "ReturnData", "UseItemId", "FormulaId", "MonthCardOutDateTime" }, null, null, null, null)
		}));
	}
}
