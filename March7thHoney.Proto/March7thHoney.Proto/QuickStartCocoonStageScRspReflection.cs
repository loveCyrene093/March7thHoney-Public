using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuickStartCocoonStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuickStartCocoonStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiBRdWlja1N0YXJ0Q29jb29uU3RhZ2VTY1JzcC5wcm90bxoVU2NlbmVCYXR0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bGVJbmZvLnByb3RvIoQBChpRdWlja1N0YXJ0Q29jb29uU3RhZ2VTY1JzcBIR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Cgljb2Nvb25faWQYAyABKA0SDAoEd2F2ZRgEIAEoDRIlCgtiYXR0bGVfaW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "bxgFIAEoCzIQLlNjZW5lQmF0dGxlSW5mbxINCgVDb3VudBgHIAEoDRIPCgdy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZXRjb2RlGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuickStartCocoonStageScRsp), QuickStartCocoonStageScRsp.Parser, new string[5] { "CocoonId", "Wave", "BattleInfo", "Count", "Retcode" }, null, null, null, null)
		}));
	}
}
