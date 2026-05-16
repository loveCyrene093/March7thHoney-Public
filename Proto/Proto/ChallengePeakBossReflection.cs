using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengePeakBossReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengePeakBossReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChdDaGFsbGVuZ2VQZWFrQm9zcy5wcm90bxogQ2hhbGxlbmdlUGVha0Jvc3ND";
		buffer[1] = "bGVhcmFuY2UucHJvdG8ixAEKEUNoYWxsZW5nZVBlYWtCb3NzEhMKC0xKR0RD";
		buffer[2] = "R0JGTktOGAEgASgNEhwKFGZpbmlzaGVkX3RhcmdldF9saXN0GAIgAygNEi4K";
		buffer[3] = "CWhhcmRfbW9kZRgGIAEoCzIbLkNoYWxsZW5nZVBlYWtCb3NzQ2xlYXJhbmNl";
		buffer[4] = "EhwKFGhhcmRfbW9kZV9oYXNfcGFzc2VkGAcgASgIEi4KCWVhc3lfbW9kZRgO";
		buffer[5] = "IAEoCzIbLkNoYWxsZW5nZVBlYWtCb3NzQ2xlYXJhbmNlQhaqAhNNYXJjaDd0";
		buffer[6] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ChallengePeakBossClearanceReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengePeakBoss), ChallengePeakBoss.Parser, new string[5] { "LJGDCGBFNKN", "FinishedTargetList", "HardMode", "HardModeHasPassed", "EasyMode" }, null, null, null, null)
		}));
	}
}
