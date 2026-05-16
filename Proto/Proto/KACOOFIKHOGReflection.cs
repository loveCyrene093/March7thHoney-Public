using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KACOOFIKHOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KACOOFIKHOGReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFLQUNPT0ZJS0hPRy5wcm90bxogVHJhaW5QYXJ0eU10U2tpbGxCcmllZlR5";
		buffer[1] = "cGUucHJvdG8iZQoLS0FDT09GSUtIT0cSLwoKc2tpbGxfdHlwZRgIIAEoDjIb";
		buffer[2] = "LlRyYWluUGFydHlNdFNraWxsQnJpZWZUeXBlEhAKCHNraWxsX2lkGAsgASgN";
		buffer[3] = "EhMKC0VOT09FRkxKSUZIGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[4] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { TrainPartyMtSkillBriefTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KACOOFIKHOG), KACOOFIKHOG.Parser, new string[3] { "SkillType", "SkillId", "ENOOEFLJIFH" }, null, null, null, null)
		}));
	}
}
