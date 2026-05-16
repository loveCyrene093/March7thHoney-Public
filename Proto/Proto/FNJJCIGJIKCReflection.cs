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
		buffer[0] = "ChFGTkpKQ0lHSklLQy5wcm90bxoQTGluZXVwSW5mby5wcm90bxoPU2NlbmVJ";
		buffer[1] = "bmZvLnByb3RvInEKC0ZOSkpDSUdKSUtDEhMKC3dvcmxkX2xldmVsGAEgASgN";
		buffer[2] = "EhsKBmxpbmV1cBgJIAEoCzILLkxpbmV1cEluZm8SHwoLRkhKRU9BS0RDQkMY";
		buffer[3] = "CyABKAsyCi5TY2VuZUluZm8SDwoHcmFpZF9pZBgNIAEoDUIWqgITTWFyY2g3";
		buffer[4] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			LineupInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FNJJCIGJIKC), FNJJCIGJIKC.Parser, new string[4] { "WorldLevel", "Lineup", "FHJEOAKDCBC", "RaidId" }, null, null, null, null)
		}));
	}
}
