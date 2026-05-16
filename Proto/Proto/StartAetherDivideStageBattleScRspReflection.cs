using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartAetherDivideStageBattleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartAetherDivideStageBattleScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidTdGFydEFldGhlckRpdmlkZVN0YWdlQmF0dGxlU2NSc3AucHJvdG8aHEFl";
		buffer[1] = "dGhlckRpdmlkZUJhdHRsZUluZm8ucHJvdG8iYgohU3RhcnRBZXRoZXJEaXZp";
		buffer[2] = "ZGVTdGFnZUJhdHRsZVNjUnNwEg8KB3JldGNvZGUYBSABKA0SLAoLYmF0dGxl";
		buffer[3] = "X2luZm8YDCABKAsyFy5BZXRoZXJEaXZpZGVCYXR0bGVJbmZvQhaqAhNNYXJj";
		buffer[4] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AetherDivideBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartAetherDivideStageBattleScRsp), StartAetherDivideStageBattleScRsp.Parser, new string[2] { "Retcode", "BattleInfo" }, null, null, null, null)
		}));
	}
}
