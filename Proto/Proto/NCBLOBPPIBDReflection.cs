using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NCBLOBPPIBDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NCBLOBPPIBDReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFOQ0JMT0JQUElCRC5wcm90bxofQ2hpbWVyYUR1ZWxQbGF5ZXJSYW5rRGF0";
		buffer[1] = "YS5wcm90bxoRSFBITU1QREZNQUsucHJvdG8i9AEKC05DQkxPQlBQSUJEEhMK";
		buffer[2] = "C0JFS0NISU1ETkpHGAEgASgNEhMKC01BUEROTEJISENEGAQgASgNEhMKC01N";
		buffer[3] = "SUlJTkpETEFNGAYgAygNEhMKC0NLSkVDT0hLQ0xMGAcgAygNEhMKC0pOTUJK";
		buffer[4] = "SEpQQk9LGAggASgNEhMKC0pHTEtORU9DSkNIGAogASgNEi8KC0dFUEdHR0RL";
		buffer[5] = "Qk5LGAsgASgLMhouQ2hpbWVyYUR1ZWxQbGF5ZXJSYW5rRGF0YRITCgtHTENP";
		buffer[6] = "SU5IS0hNTRgOIAMoDRIhCgtFQVBMR0lPRkRERxgPIAMoCzIMLkhQSE1NUERG";
		buffer[7] = "TUFLQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ChimeraDuelPlayerRankDataReflection.Descriptor,
			HPHMMPDFMAKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NCBLOBPPIBD), NCBLOBPPIBD.Parser, new string[9] { "BEKCHIMDNJG", "MAPDNLBHHCD", "MMIIINJDLAM", "CKJECOHKCLL", "JNMBJHJPBOK", "JGLKNEOCJCH", "GEPGGGDKBNK", "GLCOINHKHMM", "EAPLGIOFDDG" }, null, null, null, null)
		}));
	}
}
