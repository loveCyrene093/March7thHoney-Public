using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IDBCHLBACNDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IDBCHLBACNDReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFJREJDSExCQUNORC5wcm90byKLAQoLSURCQ0hMQkFDTkQSEwoLQklQSkVI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SU9FR04YASABKA0SEwoLQkxCR0ZJR0pCTkQYBCABKA0SEwoLSUdJS0tHTE1K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "RUQYCCABKA0SEwoLRkVCSExNTkhGT0MYCSABKA0SEwoLTUtIRE9QR0dCSUUY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CyABKAgSEwoLUE1JQ0lDUFBET1AYDSABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IDBCHLBACND), IDBCHLBACND.Parser, new string[6] { "BIPJEHIOEGN", "BLBGFIGJBND", "IGIKKGLMJED", "FEBHLMNHFOC", "MKHDOPGGBIE", "PMICICPPDOP" }, null, null, null, null)
		}));
	}
}
