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
		buffer[0] = "CiJSZUVudGVyTGFzdEVsZW1lbnRTdGFnZVNjUnNwLnByb3RvGhVTY2VuZUJh";
		buffer[1] = "dHRsZUluZm8ucHJvdG8iaAocUmVFbnRlckxhc3RFbGVtZW50U3RhZ2VTY1Jz";
		buffer[2] = "cBIlCgtiYXR0bGVfaW5mbxgDIAEoCzIQLlNjZW5lQmF0dGxlSW5mbxIQCghz";
		buffer[3] = "dGFnZV9pZBgNIAEoDRIPCgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhv";
		buffer[4] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReEnterLastElementStageScRsp), ReEnterLastElementStageScRsp.Parser, new string[3] { "BattleInfo", "StageId", "Retcode" }, null, null, null, null)
		}));
	}
}
