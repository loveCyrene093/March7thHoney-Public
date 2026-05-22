using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartAetherDivideSceneBattleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartAetherDivideSceneBattleScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CidTdGFydEFldGhlckRpdmlkZVNjZW5lQmF0dGxlU2NSc3AucHJvdG8aHEFl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "dGhlckRpdmlkZUJhdHRsZUluZm8ucHJvdG8iegohU3RhcnRBZXRoZXJEaXZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "ZGVTY2VuZUJhdHRsZVNjUnNwEiwKC2JhdHRsZV9pbmZvGAYgASgLMhcuQWV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "aGVyRGl2aWRlQmF0dGxlSW5mbxIPCgdyZXRjb2RlGAggASgNEhYKDmNhc3Rf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ZW50aXR5X2lkGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { AetherDivideBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartAetherDivideSceneBattleScRsp), StartAetherDivideSceneBattleScRsp.Parser, new string[3] { "BattleInfo", "Retcode", "CastEntityId" }, null, null, null, null)
		}));
	}
}
