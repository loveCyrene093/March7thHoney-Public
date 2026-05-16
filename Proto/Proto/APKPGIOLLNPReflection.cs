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
		buffer[0] = "ChFBUEtQR0lPTExOUC5wcm90bxoRR0tERUtKS09JSk4ucHJvdG8ihwEKC0FQ";
		buffer[1] = "S1BHSU9MTE5QEiEKC0ZNUE5OSERQR0tEGAIgAygLMgwuR0tERUtKS09JSk4S";
		buffer[2] = "IQoLTUVLTElCQVBHT04YAyADKAsyDC5HS0RFS0pLT0lKThIPCgdyZXRjb2Rl";
		buffer[3] = "GAcgASgNEiEKC0hFT0VLQVBCTklFGA0gAygLMgwuR0tERUtKS09JSk5CFqoC";
		buffer[4] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GKDEKJKOIJNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APKPGIOLLNP), APKPGIOLLNP.Parser, new string[4] { "FMPNNHDPGKD", "MEKLIBAPGON", "Retcode", "HEOEKAPBNIE" }, null, null, null, null)
		}));
	}
}
