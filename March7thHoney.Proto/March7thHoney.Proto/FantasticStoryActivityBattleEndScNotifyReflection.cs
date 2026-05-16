using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FantasticStoryActivityBattleEndScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FantasticStoryActivityBattleEndScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ci1GYW50YXN0aWNTdG9yeUFjdGl2aXR5QmF0dGxlRW5kU2NOb3RpZnkucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dG8iZgonRmFudGFzdGljU3RvcnlBY3Rpdml0eUJhdHRsZUVuZFNjTm90aWZ5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EhMKC0NFSU1OREpGREpEGAIgASgNEhMKC0pIR0FOSkdCQUxJGAMgASgNEhEK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CWJhdHRsZV9pZBgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FantasticStoryActivityBattleEndScNotify), FantasticStoryActivityBattleEndScNotify.Parser, new string[3] { "CEIMNDJFDJD", "JHGANJGBALI", "BattleId" }, null, null, null, null)
		}));
	}
}
