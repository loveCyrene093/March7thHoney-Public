using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MACJBIAFNOIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MACJBIAFNOIReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFNQUNKQklBRk5PSS5wcm90bxoMVmVjdG9yLnByb3RvIsABCgtNQUNKQklB";
		buffer[1] = "Rk5PSRIUCgNwb3MYASABKAsyBy5WZWN0b3ISFAoDcm90GAIgASgLMgcuVmVj";
		buffer[2] = "dG9yEhMKC0dOR0tORENLS0tDGAMgASgCEhwKC05BTEJFRk1PS0lCGAQgASgL";
		buffer[3] = "MgcuVmVjdG9yEhMKC0RDQkJLRkZISERMGAUgASgCEhMKC0pDQkdIQU9ETkRE";
		buffer[4] = "GAYgASgNEhMKC01FS1BJSEpLSkJMGAcgASgIEhMKC0tIQUpES0RIUEdEGAgg";
		buffer[5] = "ASgDQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { VectorReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MACJBIAFNOI), MACJBIAFNOI.Parser, new string[8] { "Pos", "Rot", "GNGKNDCKKKC", "NALBEFMOKIB", "DCBBKFFHHDL", "JCBGHAODNDD", "MEKPIHJKJBL", "KHAJDKDHPGD" }, null, null, null, null)
		}));
	}
}
