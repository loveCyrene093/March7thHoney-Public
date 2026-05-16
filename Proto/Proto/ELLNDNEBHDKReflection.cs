using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ELLNDNEBHDKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ELLNDNEBHDKReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFFTExORE5FQkhESy5wcm90bxoRSkVITkJERE1JRUoucHJvdG8ikQEKC0VM";
		buffer[1] = "TE5ETkVCSERLEiEKC09DTExBREJGS0hQGAMgASgLMgwuSkVITkJERE1JRUoS";
		buffer[2] = "EwoLTEdQUEZLREtIRUMYBCABKA0SEwoLT0NJTktNT0FNT00YBiABKA0SDgoG";
		buffer[3] = "c3RhdHVzGAggASgNEhMKC0lIRUpPR0hEUE1JGAsgASgBEhAKCHNjb3JlX2lk";
		buffer[4] = "GAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JEHNBDDMIEJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ELLNDNEBHDK), ELLNDNEBHDK.Parser, new string[6] { "OCLLADBFKHP", "LGPPFKDKHEC", "OCINKMOAMOM", "Status", "IHEJOGHDPMI", "ScoreId" }, null, null, null, null)
		}));
	}
}
