using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PHNHEEOLADLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PHNHEEOLADLReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFQSE5IRUVPTEFETC5wcm90bxoWQmF0dGxlUmVjb3JkVHlwZS5wcm90bxob";
		buffer[1] = "RnJpZW5kR3JpZEZpZ2h0UmVjb3JkLnByb3RvGhFLSUVFRkFPQ09DQy5wcm90";
		buffer[2] = "bxoRS01BRE5HSk5PT0IucHJvdG8iqAEKC1BITkhFRU9MQURMEiEKC05BS0tP";
		buffer[3] = "SEVNSkJMGAIgASgLMgwuS0lFRUZBT0NPQ0MSIQoLQkhFRURBRkxFT0oYAyAB";
		buffer[4] = "KAsyDC5LTUFETkdKTk9PQhImCgtIQ1BBSFBDT0VLSxgJIAEoDjIRLkJhdHRs";
		buffer[5] = "ZVJlY29yZFR5cGUSKwoLS0lJT05KQkRLTkoYDiABKAsyFi5GcmllbmRHcmlk";
		buffer[6] = "RmlnaHRSZWNvcmRCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			BattleRecordTypeReflection.Descriptor,
			FriendGridFightRecordReflection.Descriptor,
			KIEEFAOCOCCReflection.Descriptor,
			KMADNGJNOOBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PHNHEEOLADL), PHNHEEOLADL.Parser, new string[4] { "NAKKOHEMJBL", "BHEEDAFLEOJ", "HCPAHPCOEKK", "KIIONJBDKNJ" }, null, null, null, null)
		}));
	}
}
