using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateSettleScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateSettleScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChhGYXRlU2V0dGxlU2NOb3RpZnkucHJvdG8aEUlIR0JEQUdIRE1FLnByb3Rv";
		buffer[1] = "Gg5JdGVtTGlzdC5wcm90byJkChJGYXRlU2V0dGxlU2NOb3RpZnkSIQoLQU5M";
		buffer[2] = "R09QSEhIRlAYASABKAsyDC5JSEdCREFHSERNRRIQCghzY29yZV9pZBgCIAEo";
		buffer[3] = "DRIZCgZyZXdhcmQYByABKAsyCS5JdGVtTGlzdEIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			IHGBDAGHDMEReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateSettleScNotify), FateSettleScNotify.Parser, new string[3] { "ANLGOPHHHFP", "ScoreId", "Reward" }, null, null, null, null)
		}));
	}
}
