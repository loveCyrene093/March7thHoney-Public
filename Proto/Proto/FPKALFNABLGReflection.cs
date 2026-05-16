using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FPKALFNABLGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FPKALFNABLGReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFGUEtBTEZOQUJMRy5wcm90bxoRS0JPSkFDQUVBREwucHJvdG8iggEKC0ZQ";
		buffer[1] = "S0FMRk5BQkxHEiEKC0JJS0hPRUdGRUZEGAIgASgLMgwuS0JPSkFDQUVBREwS";
		buffer[2] = "EwoLSUNJTEJORElER1AYDCABKAgSFQoLQkZOQUhBSUdPQkgYDSABKA1IABIV";
		buffer[3] = "CgtNUEVLUEJNSU1DUBgPIAEoCEgAQg0KC0NFTEdIQUJJT09OQhaqAhNNYXJj";
		buffer[4] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { KBOJACAEADLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FPKALFNABLG), FPKALFNABLG.Parser, new string[4] { "BIKHOEGFEFD", "ICILBNDIDGP", "BFNAHAIGOBH", "MPEKPBMIMCP" }, new string[1] { "CELGHABIOON" }, null, null, null)
		}));
	}
}
