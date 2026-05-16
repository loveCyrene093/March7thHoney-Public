using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartChallengePeakCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartChallengePeakCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1TdGFydENoYWxsZW5nZVBlYWtDc1JlcS5wcm90bxoRRUVCUEhKQ05CRk8u";
		buffer[1] = "cHJvdG8igAEKF1N0YXJ0Q2hhbGxlbmdlUGVha0NzUmVxEg8KB3BlYWtfaWQY";
		buffer[2] = "AyABKA0SIQoLRk1GR09KSENDTkwYBCADKAsyDC5FRUJQSEpDTkJGTxIUCgxi";
		buffer[3] = "b3NzX2J1ZmZfaWQYBiABKA0SGwoTcGVha19hdmF0YXJfaWRfbGlzdBgPIAMo";
		buffer[4] = "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EEBPHJCNBFOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartChallengePeakCsReq), StartChallengePeakCsReq.Parser, new string[4] { "PeakId", "FMFGOJHCCNL", "BossBuffId", "PeakAvatarIdList" }, null, null, null, null)
		}));
	}
}
