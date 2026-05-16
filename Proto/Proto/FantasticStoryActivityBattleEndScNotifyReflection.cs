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
		buffer[0] = "Ci1GYW50YXN0aWNTdG9yeUFjdGl2aXR5QmF0dGxlRW5kU2NOb3RpZnkucHJv";
		buffer[1] = "dG8iZgonRmFudGFzdGljU3RvcnlBY3Rpdml0eUJhdHRsZUVuZFNjTm90aWZ5";
		buffer[2] = "EhMKC0NFSU1OREpGREpEGAIgASgNEhMKC0pIR0FOSkdCQUxJGAMgASgNEhEK";
		buffer[3] = "CWJhdHRsZV9pZBgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FantasticStoryActivityBattleEndScNotify), FantasticStoryActivityBattleEndScNotify.Parser, new string[3] { "CEIMNDJFDJD", "JHGANJGBALI", "BattleId" }, null, null, null, null)
		}));
	}
}
