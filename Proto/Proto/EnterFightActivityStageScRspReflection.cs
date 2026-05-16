using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterFightActivityStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterFightActivityStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJFbnRlckZpZ2h0QWN0aXZpdHlTdGFnZVNjUnNwLnByb3RvGhVTY2VuZUJh";
		buffer[1] = "dHRsZUluZm8ucHJvdG8ifQocRW50ZXJGaWdodEFjdGl2aXR5U3RhZ2VTY1Jz";
		buffer[2] = "cBIlCgtiYXR0bGVfaW5mbxgBIAEoCzIQLlNjZW5lQmF0dGxlSW5mbxIQCghn";
		buffer[3] = "cm91cF9pZBgMIAEoDRITCgtJTk9NRkZBSUVPQRgNIAEoDRIPCgdyZXRjb2Rl";
		buffer[4] = "GA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterFightActivityStageScRsp), EnterFightActivityStageScRsp.Parser, new string[4] { "BattleInfo", "GroupId", "INOMFFAIEOA", "Retcode" }, null, null, null, null)
		}));
	}
}
