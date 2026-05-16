using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyMtSkillBriefTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyMtSkillBriefTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiBUcmFpblBhcnR5TXRTa2lsbEJyaWVmVHlwZS5wcm90byqtAQoaVHJhaW5Q";
		buffer[1] = "YXJ0eU10U2tpbGxCcmllZlR5cGUSGwoXSEpCRktIR0FBSklfSElCT1BIT0hH";
		buffer[2] = "REwQABIbChdISkJGS0hHQUFKSV9JSEJPQ0ZJUEhJSRABEhsKF0hKQkZLSEdB";
		buffer[3] = "QUpJX0tFTUpDTktLQUZFEAISGwoXSEpCRktIR0FBSklfS01BSkJORkFBUEIQ";
		buffer[4] = "AxIbChdISkJGS0hHQUFKSV9JQkJBQ0xFREdGRxAEQhaqAhNNYXJjaDd0aEhv";
		buffer[5] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(TrainPartyMtSkillBriefType) }, null, null));
	}
}
