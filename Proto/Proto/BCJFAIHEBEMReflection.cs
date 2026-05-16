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
		buffer[0] = "ChFCQ0pGQUlIRUJFTS5wcm90bxoRQk1PRUVLR0NKQUQucHJvdG8aEUdLREVL";
		buffer[1] = "SktPSUpOLnByb3RvIpkBCgtCQ0pGQUlIRUJFTRIhCgtLSEhOT0hQRU9JQRgC";
		buffer[2] = "IAMoCzIMLkJNT0VFS0dDSkFEEhMKC0FIR0VLSUJQSExEGAYgAygNEiEKC0FE";
		buffer[3] = "SUxQSU1FT0FEGAogAygLMgwuR0tERUtKS09JSk4SLwoZZ3JpZF9maWdodF9l";
		buffer[4] = "cXVpcG1lbnRfbGlzdBgPIAMoCzIMLkJNT0VFS0dDSkFEQhaqAhNNYXJjaDd0";
		buffer[5] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BMOEEKGCJADReflection.Descriptor,
			GKDEKJKOIJNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BCJFAIHEBEM), BCJFAIHEBEM.Parser, new string[4] { "KHHNOHPEOIA", "AHGEKIBPHLD", "ADILPIMEOAD", "GridFightEquipmentList" }, null, null, null, null)
		}));
	}
}
