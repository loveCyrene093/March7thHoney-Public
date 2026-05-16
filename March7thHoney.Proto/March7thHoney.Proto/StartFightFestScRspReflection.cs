using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartFightFestScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartFightFestScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChlTdGFydEZpZ2h0RmVzdFNjUnNwLnByb3RvGhNGaWdodEZlc3RUeXBlLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "b3RvGhVTY2VuZUJhdHRsZUluZm8ucHJvdG8iiQEKE1N0YXJ0RmlnaHRGZXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "U2NSc3ASJQoLYmF0dGxlX2luZm8YBiABKAsyEC5TY2VuZUJhdHRsZUluZm8S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "CgoCaWQYCCABKA0SHAoEdHlwZRgJIAEoDjIOLkZpZ2h0RmVzdFR5cGUSDwoH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "cmV0Y29kZRgLIAEoDRIQCghldmVudF9pZBgOIAEoDUIWqgITTWFyY2g3dGhI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			FightFestTypeReflection.Descriptor,
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartFightFestScRsp), StartFightFestScRsp.Parser, new string[5] { "BattleInfo", "Id", "Type", "Retcode", "EventId" }, null, null, null, null)
		}));
	}
}
