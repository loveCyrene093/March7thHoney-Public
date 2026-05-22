using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMarbleTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMarbleTypeReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChNDbWRNYXJibGVUeXBlLnByb3RvKtUCCg1DbWRNYXJibGVUeXBlEhsKF0pH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "SU9KREdEQU9EX1BDUERIRUxQS0VNEAASGgoVQ21kTWFyYmxlR2V0RGF0YVNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "UnNwEOJAEiMKHkNtZE1hcmJsZVB2cERhdGFVcGRhdGVTY05vdGlmeRDfQBIa";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "ChVDbWRNYXJibGVHZXREYXRhQ3NSZXEQz0ASIgodQ21kTWFyYmxlVXBkYXRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "U2hvd25TZWFsQ3NSZXEQ1UASGgoVQ21kTWFyYmxlU2hvcEJ1eVNjUnNwENZA";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "EiAKG0NtZE1hcmJsZVVubG9ja1NlYWxTY05vdGlmeRDcQBIiCh1DbWRNYXJi";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "bGVVcGRhdGVTaG93blNlYWxTY1JzcBDhQBITCg5DbWRQQ1BKS09IRkVDRRDY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "QBITCg5DbWRJRkpESktNTUFCTBDQQBIaChVDbWRNYXJibGVTaG9wQnV5Q3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "ZXEQ3UBCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMarbleType) }, null, null));
	}
}
