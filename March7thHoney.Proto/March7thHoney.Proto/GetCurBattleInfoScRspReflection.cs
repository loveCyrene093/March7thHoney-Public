using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCurBattleInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCurBattleInfoScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChtHZXRDdXJCYXR0bGVJbmZvU2NSc3AucHJvdG8aHEFldGhlckRpdmlkZUJh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "dHRsZUluZm8ucHJvdG8aFUJhdHRsZUVuZFN0YXR1cy5wcm90bxoVU2NlbmVC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "YXR0bGVJbmZvLnByb3RvIr0BChVHZXRDdXJCYXR0bGVJbmZvU2NSc3ASDwoH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "cmV0Y29kZRgEIAEoDRIsCgtEUENOQ0xJQkpCQxgKIAEoCzIXLkFldGhlckRp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "dmlkZUJhdHRsZUluZm8SJQoLYmF0dGxlX2luZm8YDCABKAsyEC5TY2VuZUJh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "dHRsZUluZm8SEwoLSE1CR09QT0xPSk8YDSABKA0SKQoPbGFzdF9lbmRfc3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "dHVzGA8gASgOMhAuQmF0dGxlRW5kU3RhdHVzQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[3]
		{
			AetherDivideBattleInfoReflection.Descriptor,
			BattleEndStatusReflection.Descriptor,
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurBattleInfoScRsp), GetCurBattleInfoScRsp.Parser, new string[5] { "Retcode", "DPCNCLIBJBC", "BattleInfo", "HMBGOPOLOJO", "LastEndStatus" }, null, null, null, null)
		}));
	}
}
