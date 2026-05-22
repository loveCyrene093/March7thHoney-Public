using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BCJFAIHEBEMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BCJFAIHEBEMReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFCQ0pGQUlIRUJFTS5wcm90bxoRQk1PRUVLR0NKQUQucHJvdG8aEUdLREVL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "SktPSUpOLnByb3RvIpkBCgtCQ0pGQUlIRUJFTRIhCgtLSEhOT0hQRU9JQRgC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "IAMoCzIMLkJNT0VFS0dDSkFEEhMKC0FIR0VLSUJQSExEGAYgAygNEiEKC0FE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "SUxQSU1FT0FEGAogAygLMgwuR0tERUtKS09JSk4SLwoZZ3JpZF9maWdodF9l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "cXVpcG1lbnRfbGlzdBgPIAMoCzIMLkJNT0VFS0dDSkFEQhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			BMOEEKGCJADReflection.Descriptor,
			GKDEKJKOIJNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BCJFAIHEBEM), BCJFAIHEBEM.Parser, new string[4] { "KHHNOHPEOIA", "AHGEKIBPHLD", "ADILPIMEOAD", "GridFightEquipmentList" }, null, null, null, null)
		}));
	}
}
