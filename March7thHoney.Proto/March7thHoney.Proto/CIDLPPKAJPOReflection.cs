using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CIDLPPKAJPOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CIDLPPKAJPOReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFDSURMUFBLQUpQTy5wcm90bxoRQUFDREJDS0FGQ0EucHJvdG8aEUhIQktB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "TkxCQ0NQLnByb3RvIooBCgtDSURMUFBLQUpQTxIRCgl1bmlxdWVfaWQYCiAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "KA0SDwoHY2FyZF9pZBgOIAEoDRIjCgtMR0pIR09ETkpHTRgDIAEoCzIMLkFB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "Q0RCQ0tBRkNBSAASIwoLSEdQSUdHTEJGTU0YCyABKAsyDC5ISEJLQU5MQkND";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "UEgAQg0KC0lIQ0lBSElGUExMQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			AACDBCKAFCAReflection.Descriptor,
			HHBKANLBCCPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CIDLPPKAJPO), CIDLPPKAJPO.Parser, new string[4] { "UniqueId", "CardId", "LGJHGODNJGM", "HGPIGGLBFMM" }, new string[1] { "IHCIAHIFPLL" }, null, null, null)
		}));
	}
}
