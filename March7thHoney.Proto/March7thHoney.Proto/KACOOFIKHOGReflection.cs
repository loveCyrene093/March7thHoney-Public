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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFLQUNPT0ZJS0hPRy5wcm90bxogVHJhaW5QYXJ0eU10U2tpbGxCcmllZlR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cGUucHJvdG8iZQoLS0FDT09GSUtIT0cSLwoKc2tpbGxfdHlwZRgIIAEoDjIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "LlRyYWluUGFydHlNdFNraWxsQnJpZWZUeXBlEhAKCHNraWxsX2lkGAsgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "EhMKC0VOT09FRkxKSUZIGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { TrainPartyMtSkillBriefTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KACOOFIKHOG), KACOOFIKHOG.Parser, new string[3] { "SkillType", "SkillId", "ENOOEFLJIFH" }, null, null, null, null)
		}));
	}
}
