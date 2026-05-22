using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartAetherDivideChallengeBattleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartAetherDivideChallengeBattleScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CitTdGFydEFldGhlckRpdmlkZUNoYWxsZW5nZUJhdHRsZVNjUnNwLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "GhxBZXRoZXJEaXZpZGVCYXR0bGVJbmZvLnByb3RvImYKJVN0YXJ0QWV0aGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "RGl2aWRlQ2hhbGxlbmdlQmF0dGxlU2NSc3ASLAoLYmF0dGxlX2luZm8YAyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KAsyFy5BZXRoZXJEaXZpZGVCYXR0bGVJbmZvEg8KB3JldGNvZGUYCCABKA1C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { AetherDivideBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartAetherDivideChallengeBattleScRsp), StartAetherDivideChallengeBattleScRsp.Parser, new string[2] { "BattleInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
