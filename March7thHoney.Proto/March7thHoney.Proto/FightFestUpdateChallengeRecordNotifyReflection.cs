using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightFestUpdateChallengeRecordNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightFestUpdateChallengeRecordNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CipGaWdodEZlc3RVcGRhdGVDaGFsbGVuZ2VSZWNvcmROb3RpZnkucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "EVBCT0ZJQkxCUEdKLnByb3RvIqMBCiRGaWdodEZlc3RVcGRhdGVDaGFsbGVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "Z2VSZWNvcmROb3RpZnkSEwoLSEVJTEtCSkNBR0IYAyABKA0SIQoLTEpNTE5J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "TkRIRUYYBCABKA4yDC5QQk9GSUJMQlBHShIaCgRyYW5rGAUgASgOMgwuUEJP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "RklCTEJQR0oSFAoMY2hhbGxlbmdlX2lkGAYgASgNEhEKCXR1cm5fbGVmdBgM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { PBOFIBLBPGJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FightFestUpdateChallengeRecordNotify), FightFestUpdateChallengeRecordNotify.Parser, new string[5] { "HEILKBJCAGB", "LJMLNINDHEF", "Rank", "ChallengeId", "TurnLeft" }, null, null, null, null)
		}));
	}
}
