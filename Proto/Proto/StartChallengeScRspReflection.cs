using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartChallengeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartChallengeScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChlTdGFydENoYWxsZW5nZVNjUnNwLnByb3RvGhhDaGFsbGVuZ2VTdGFnZUlu";
		buffer[1] = "Zm8ucHJvdG8aEkN1ckNoYWxsZW5nZS5wcm90bxoQTGluZXVwSW5mby5wcm90";
		buffer[2] = "bxoPU2NlbmVJbmZvLnByb3RvIrIBChNTdGFydENoYWxsZW5nZVNjUnNwEicK";
		buffer[3] = "CnN0YWdlX2luZm8YAiABKAsyEy5DaGFsbGVuZ2VTdGFnZUluZm8SJAoNY3Vy";
		buffer[4] = "X2NoYWxsZW5nZRgDIAEoCzINLkN1ckNoYWxsZW5nZRIPCgdyZXRjb2RlGAkg";
		buffer[5] = "ASgNEiAKC2xpbmV1cF9saXN0GA0gAygLMgsuTGluZXVwSW5mbxIZCgVzY2Vu";
		buffer[6] = "ZRgPIAEoCzIKLlNjZW5lSW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[7] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			ChallengeStageInfoReflection.Descriptor,
			CurChallengeReflection.Descriptor,
			LineupInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartChallengeScRsp), StartChallengeScRsp.Parser, new string[5] { "StageInfo", "CurChallenge", "Retcode", "LineupList", "Scene" }, null, null, null, null)
		}));
	}
}
