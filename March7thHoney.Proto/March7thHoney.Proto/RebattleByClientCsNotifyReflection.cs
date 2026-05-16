using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RebattleByClientCsNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RebattleByClientCsNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5SZWJhdHRsZUJ5Q2xpZW50Q3NOb3RpZnkucHJvdG8aFkJhdHRsZVN0YXRp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "c3RpY3MucHJvdG8aElJlYmF0dGxlVHlwZS5wcm90byJeChhSZWJhdHRsZUJ5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Q2xpZW50Q3NOb3RpZnkSHgoDc3R0GAIgASgLMhEuQmF0dGxlU3RhdGlzdGlj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cxIiCgtNR0FCTUNCT0hNSxgJIAEoDjINLlJlYmF0dGxlVHlwZUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			BattleStatisticsReflection.Descriptor,
			RebattleTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RebattleByClientCsNotify), RebattleByClientCsNotify.Parser, new string[2] { "Stt", "MGABMCBOHMK" }, null, null, null, null)
		}));
	}
}
