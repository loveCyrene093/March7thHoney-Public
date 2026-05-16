using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LPHJKGLLJIPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LPHJKGLLJIPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMUEhKS0dMTEpJUC5wcm90bxoRR0NIUE5IQkRDRE8ucHJvdG8aEUdQRk1F";
		buffer[1] = "RExMS0dILnByb3RvImcKC0xQSEpLR0xMSklQEiEKC0VHTENLR0tFQ0FKGAQg";
		buffer[2] = "ASgOMgwuR0NIUE5IQkRDRE8SIQoLUE1DQkJNS01ITkkYBiADKAsyDC5HUEZN";
		buffer[3] = "RURMTEtHSBISCgppdGVtX3ZhbHVlGAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[4] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GCHPNHBDCDOReflection.Descriptor,
			GPFMEDLLKGHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LPHJKGLLJIP), LPHJKGLLJIP.Parser, new string[3] { "EGLCKGKECAJ", "PMCBBMKMHNI", "ItemValue" }, null, null, null, null)
		}));
	}
}
