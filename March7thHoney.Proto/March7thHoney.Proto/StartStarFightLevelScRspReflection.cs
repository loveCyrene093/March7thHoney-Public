using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartStarFightLevelScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartStarFightLevelScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5TdGFydFN0YXJGaWdodExldmVsU2NSc3AucHJvdG8aFVNjZW5lQmF0dGxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SW5mby5wcm90byJ5ChhTdGFydFN0YXJGaWdodExldmVsU2NSc3ASEAoIZ3Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dXBfaWQYAiABKA0SJQoLYmF0dGxlX2luZm8YAyABKAsyEC5TY2VuZUJhdHRs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ZUluZm8SEwoLSU5PTUZGQUlFT0EYBSABKA0SDwoHcmV0Y29kZRgMIAEoDUIW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartStarFightLevelScRsp), StartStarFightLevelScRsp.Parser, new string[4] { "GroupId", "BattleInfo", "INOMFFAIEOA", "Retcode" }, null, null, null, null)
		}));
	}
}
