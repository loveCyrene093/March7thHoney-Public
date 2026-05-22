using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APKPGIOLLNPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APKPGIOLLNPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFBUEtQR0lPTExOUC5wcm90bxoRR0tERUtKS09JSk4ucHJvdG8ihwEKC0FQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "S1BHSU9MTE5QEiEKC0ZNUE5OSERQR0tEGAIgAygLMgwuR0tERUtKS09JSk4S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "IQoLTUVLTElCQVBHT04YAyADKAsyDC5HS0RFS0pLT0lKThIPCgdyZXRjb2Rl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "GAcgASgNEiEKC0hFT0VLQVBCTklFGA0gAygLMgwuR0tERUtKS09JSk5CFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GKDEKJKOIJNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APKPGIOLLNP), APKPGIOLLNP.Parser, new string[4] { "FMPNNHDPGKD", "MEKLIBAPGON", "Retcode", "HEOEKAPBNIE" }, null, null, null, null)
		}));
	}
}
