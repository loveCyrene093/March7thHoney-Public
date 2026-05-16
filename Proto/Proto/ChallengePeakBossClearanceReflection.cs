using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengePeakBossClearanceReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengePeakBossClearanceReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "CiBDaGFsbGVuZ2VQZWFrQm9zc0NsZWFyYW5jZS5wcm90bxoXRGlzcGxheUF2";
		buffer[1] = "YXRhckluZm8ucHJvdG8aEUVFQlBISkNOQkZPLnByb3RvIoUCChpDaGFsbGVu";
		buffer[2] = "Z2VQZWFrQm9zc0NsZWFyYW5jZRITCgtNQUxPQ0lNUEpQTRgDIAEoDRIhCgtG";
		buffer[3] = "TUZHT0pIQ0NOTBgEIAMoCzIMLkVFQlBISkNOQkZPEhsKE3BlYWtfYXZhdGFy";
		buffer[4] = "X2lkX2xpc3QYBSADKA0SEgoKaGFzX3Bhc3NlZBgJIAEoCBIPCgdidWZmX2lk";
		buffer[5] = "GAogASgNEhgKEGJlc3RfY3ljbGVfY291bnQYCyABKA0SEwoLSEVJTEtCSkNB";
		buffer[6] = "R0IYDSABKA0SKQoNRGlzcGxheUF2YXRhchgOIAMoCzISLkRpc3BsYXlBdmF0";
		buffer[7] = "YXJJbmZvEhMKC09IT01ETUVKTEZLGA8gAygNQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[8] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DisplayAvatarInfoReflection.Descriptor,
			EEBPHJCNBFOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengePeakBossClearance), ChallengePeakBossClearance.Parser, new string[9] { "MALOCIMPJPM", "FMFGOJHCCNL", "PeakAvatarIdList", "HasPassed", "BuffId", "BestCycleCount", "HEILKBJCAGB", "DisplayAvatar", "OHOMDMEJLFK" }, null, null, null, null)
		}));
	}
}
