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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFQSE5IRUVPTEFETC5wcm90bxoWQmF0dGxlUmVjb3JkVHlwZS5wcm90bxob";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "RnJpZW5kR3JpZEZpZ2h0UmVjb3JkLnByb3RvGhFLSUVFRkFPQ09DQy5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "bxoRS01BRE5HSk5PT0IucHJvdG8iqAEKC1BITkhFRU9MQURMEiEKC05BS0tP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "SEVNSkJMGAIgASgLMgwuS0lFRUZBT0NPQ0MSIQoLQkhFRURBRkxFT0oYAyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "KAsyDC5LTUFETkdKTk9PQhImCgtIQ1BBSFBDT0VLSxgJIAEoDjIRLkJhdHRs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "ZVJlY29yZFR5cGUSKwoLS0lJT05KQkRLTkoYDiABKAsyFi5GcmllbmRHcmlk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "RmlnaHRSZWNvcmRCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[4]
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
