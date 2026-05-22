using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReEnterLastElementStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReEnterLastElementStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJSZUVudGVyTGFzdEVsZW1lbnRTdGFnZVNjUnNwLnByb3RvGhVTY2VuZUJh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dHRsZUluZm8ucHJvdG8iaAocUmVFbnRlckxhc3RFbGVtZW50U3RhZ2VTY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "cBIlCgtiYXR0bGVfaW5mbxgDIAEoCzIQLlNjZW5lQmF0dGxlSW5mbxIQCghz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "dGFnZV9pZBgNIAEoDRIPCgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReEnterLastElementStageScRsp), ReEnterLastElementStageScRsp.Parser, new string[3] { "BattleInfo", "StageId", "Retcode" }, null, null, null, null)
		}));
	}
}
