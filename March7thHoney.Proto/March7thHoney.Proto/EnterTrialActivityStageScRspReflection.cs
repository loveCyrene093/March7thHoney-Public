using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterTrialActivityStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterTrialActivityStageScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJFbnRlclRyaWFsQWN0aXZpdHlTdGFnZVNjUnNwLnByb3RvGhVTY2VuZUJh" + "dHRsZUluZm8ucHJvdG8iVgocRW50ZXJUcmlhbEFjdGl2aXR5U3RhZ2VTY1Jz" + "cBIPCgdyZXRjb2RlGAUgASgNEiUKC2JhdHRsZV9pbmZvGA4gASgLMhAuU2Nl" + "bmVCYXR0bGVJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterTrialActivityStageScRsp), EnterTrialActivityStageScRsp.Parser, new string[2] { "Retcode", "BattleInfo" }, null, null, null, null)
		}));
	}
}
