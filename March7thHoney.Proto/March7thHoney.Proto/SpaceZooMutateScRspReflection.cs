using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpaceZooMutateScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpaceZooMutateScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChlTcGFjZVpvb011dGF0ZVNjUnNwLnByb3RvGhFETU5ESkJQR0VLRy5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "bxoRTEtKTUxQSkVQR0cucHJvdG8igQEKE1NwYWNlWm9vTXV0YXRlU2NSc3AS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "EwoLQkZBTExDR0lQT0cYASABKAgSDwoHcmV0Y29kZRgCIAEoDRIhCgtESEhN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "QkZIS0xKRxgLIAMoCzIMLkRNTkRKQlBHRUtHEiEKC0VBTUVKR0ZHTlBBGA4g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ASgLMgwuTEtKTUxQSkVQR0dCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			DMNDJBPGEKGReflection.Descriptor,
			LKJMLPJEPGGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooMutateScRsp), SpaceZooMutateScRsp.Parser, new string[4] { "BFALLCGIPOG", "Retcode", "DHHMBFHKLJG", "EAMEJGFGNPA" }, null, null, null, null)
		}));
	}
}
