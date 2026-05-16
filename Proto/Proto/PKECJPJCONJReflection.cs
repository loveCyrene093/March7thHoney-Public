using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PKECJPJCONJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PKECJPJCONJReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFQS0VDSlBKQ09OSi5wcm90bxoRSlBQSEtDSERJSkQucHJvdG8aEUtBT05L";
		buffer[1] = "SExER1BCLnByb3RvGhFNRkhPSkNDSUxMQy5wcm90bxoRT09LR0tNSU1JSUQu";
		buffer[2] = "cHJvdG8imQEKC1BLRUNKUEpDT05KEiEKC0FFS0pBQUtDREtLGAYgASgLMgwu";
		buffer[3] = "T09LR0tNSU1JSUQSIQoLQ0JHT0VIT0FNSEcYCSABKAsyDC5NRkhPSkNDSUxM";
		buffer[4] = "QxIhCgtLREdJS0NER0lHRRgKIAEoCzIMLkpQUEhLQ0hESUpEEiEKC0RDRkRE";
		buffer[5] = "QklJTUpQGA0gASgLMgwuS0FPTktITERHUEJCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[6] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			JPPHKCHDIJDReflection.Descriptor,
			KAONKHLDGPBReflection.Descriptor,
			MFHOJCCILLCReflection.Descriptor,
			OOKGKMIMIIDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PKECJPJCONJ), PKECJPJCONJ.Parser, new string[4] { "AEKJAAKCDKK", "CBGOEHOAMHG", "KDGIKCDGIGE", "DCFDDBIIMJP" }, null, null, null, null)
		}));
	}
}
