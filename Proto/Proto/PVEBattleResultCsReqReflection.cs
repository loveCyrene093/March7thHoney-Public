using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PVEBattleResultCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PVEBattleResultCsReqReflection()
	{
		InlineArray14<string> buffer = default(InlineArray14<string>);
		buffer[0] = "ChpQVkVCYXR0bGVSZXN1bHRDc1JlcS5wcm90bxoVQmF0dGxlRW5kU3RhdHVz";
		buffer[1] = "LnByb3RvGg5CYXR0bGVPcC5wcm90bxoWQmF0dGxlU3RhdGlzdGljcy5wcm90";
		buffer[2] = "byLcAwoUUFZFQmF0dGxlUmVzdWx0Q3NSZXESOwoLQ0dLRklLS05HSk4YASAD";
		buffer[3] = "KAsyJi5QVkVCYXR0bGVSZXN1bHRDc1JlcS5DR0tGSUtLTkdKTkVudHJ5EhoK";
		buffer[4] = "B29wX2xpc3QYAiADKAsyCS5CYXR0bGVPcBIeCgNzdHQYAyABKAsyES5CYXR0";
		buffer[5] = "bGVTdGF0aXN0aWNzEhEKCWNvc3RfdGltZRgEIAEoDRITCgtLSUJNRU1OQ0NE";
		buffer[6] = "ThgFIAEoCBIYChBkZWJ1Z19leHRyYV9pbmZvGAYgASgJEhMKC0VORUNQRU9H";
		buffer[7] = "RUtHGAcgASgNEiQKCmVuZF9zdGF0dXMYCCABKA4yEC5CYXR0bGVFbmRTdGF0";
		buffer[8] = "dXMSEwoLQUJBSUFFTU5FT0EYCSABKAgSEwoLREdNUERISU5QS0sYCiABKA0S";
		buffer[9] = "EwoLSklPRERBSE5NRUwYCyABKAgSGgoSY2xpZW50X3Jlc192ZXJzaW9uGAwg";
		buffer[10] = "ASgNEhoKEnR1cm5fc25hcHNob3RfaGFzaBgNIAEoDBIQCghzdGFnZV9pZBgO";
		buffer[11] = "IAEoDRIRCgliYXR0bGVfaWQYDyABKA0aMgoQQ0dLRklLS05HSk5FbnRyeRIL";
		buffer[12] = "CgNrZXkYASABKAkSDQoFdmFsdWUYAiABKA06AjgBQhaqAhNNYXJjaDd0aEhv";
		buffer[13] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			BattleEndStatusReflection.Descriptor,
			BattleOpReflection.Descriptor,
			BattleStatisticsReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PVEBattleResultCsReq), PVEBattleResultCsReq.Parser, new string[15]
			{
				"CGKFIKKNGJN", "OpList", "Stt", "CostTime", "KIBMEMNCCDN", "DebugExtraInfo", "ENECPEOGEKG", "EndStatus", "ABAIAEMNEOA", "DGMPDHINPKK",
				"JIODDAHNMEL", "ClientResVersion", "TurnSnapshotHash", "StageId", "BattleId"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
