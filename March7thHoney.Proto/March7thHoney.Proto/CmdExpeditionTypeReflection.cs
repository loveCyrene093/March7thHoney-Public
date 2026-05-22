using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdExpeditionTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdExpeditionTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChdDbWRFeHBlZGl0aW9uVHlwZS5wcm90byqpAgoRQ21kRXhwZWRpdGlvblR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "cGUSGwoXRkpLTURHTkRJTE9fUENQREhFTFBLRU0QABIlCiBDbWRBY2NlcHRN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "dWx0aXBsZUV4cGVkaXRpb25Dc1JlcRDHExIlCiBDbWRBY2NlcHRNdWx0aXBs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "ZUV4cGVkaXRpb25TY1JzcBD2ExIpCiRDbWRUYWtlTXVsdGlwbGVFeHBlZGl0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "aW9uUmV3YXJkQ3NSZXEQ1BMSHgoZQ21kR2V0RXhwZWRpdGlvbkRhdGFDc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "cRDRExIpCiRDbWRUYWtlTXVsdGlwbGVFeHBlZGl0aW9uUmV3YXJkU2NSc3AQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "4xMSEwoOQ21kR0FKTURORUtQT1AQ8xMSHgoZQ21kR2V0RXhwZWRpdGlvbkRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "dGFTY1JzcBDLE0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdExpeditionType) }, null, null));
	}
}
