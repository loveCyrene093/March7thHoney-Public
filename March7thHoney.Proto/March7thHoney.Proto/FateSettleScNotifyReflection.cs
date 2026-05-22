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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChhGYXRlU2V0dGxlU2NOb3RpZnkucHJvdG8aEUlIR0JEQUdIRE1FLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Gg5JdGVtTGlzdC5wcm90byJkChJGYXRlU2V0dGxlU2NOb3RpZnkSIQoLQU5M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "R09QSEhIRlAYASABKAsyDC5JSEdCREFHSERNRRIQCghzY29yZV9pZBgCIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "DRIZCgZyZXdhcmQYByABKAsyCS5JdGVtTGlzdEIWqgITTWFyY2g3dGhIb25l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			IHGBDAGHDMEReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateSettleScNotify), FateSettleScNotify.Parser, new string[3] { "ANLGOPHHHFP", "ScoreId", "Reward" }, null, null, null, null)
		}));
	}
}
