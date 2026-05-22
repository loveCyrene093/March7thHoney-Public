using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FNJJCIGJIKCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FNJJCIGJIKCReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFGTkpKQ0lHSklLQy5wcm90bxoQTGluZXVwSW5mby5wcm90bxoPU2NlbmVJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bmZvLnByb3RvInEKC0ZOSkpDSUdKSUtDEhMKC3dvcmxkX2xldmVsGAEgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EhsKBmxpbmV1cBgJIAEoCzILLkxpbmV1cEluZm8SHwoLRkhKRU9BS0RDQkMY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CyABKAsyCi5TY2VuZUluZm8SDwoHcmFpZF9pZBgNIAEoDUIWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			LineupInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FNJJCIGJIKC), FNJJCIGJIKC.Parser, new string[4] { "WorldLevel", "Lineup", "FHJEOAKDCBC", "RaidId" }, null, null, null, null)
		}));
	}
}
