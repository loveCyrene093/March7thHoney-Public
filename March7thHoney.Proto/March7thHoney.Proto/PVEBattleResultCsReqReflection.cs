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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 0) = "ChpQVkVCYXR0bGVSZXN1bHRDc1JlcS5wcm90bxoVQmF0dGxlRW5kU3RhdHVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 1) = "LnByb3RvGg5CYXR0bGVPcC5wcm90bxoWQmF0dGxlU3RhdGlzdGljcy5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 2) = "byLcAwoUUFZFQmF0dGxlUmVzdWx0Q3NSZXESOwoLQ0dLRklLS05HSk4YASAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 3) = "KAsyJi5QVkVCYXR0bGVSZXN1bHRDc1JlcS5DR0tGSUtLTkdKTkVudHJ5EhoK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 4) = "B29wX2xpc3QYAiADKAsyCS5CYXR0bGVPcBIeCgNzdHQYAyABKAsyES5CYXR0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 5) = "bGVTdGF0aXN0aWNzEhEKCWNvc3RfdGltZRgEIAEoDRITCgtLSUJNRU1OQ0NE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 6) = "ThgFIAEoCBIYChBkZWJ1Z19leHRyYV9pbmZvGAYgASgJEhMKC0VORUNQRU9H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 7) = "RUtHGAcgASgNEiQKCmVuZF9zdGF0dXMYCCABKA4yEC5CYXR0bGVFbmRTdGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 8) = "dXMSEwoLQUJBSUFFTU5FT0EYCSABKAgSEwoLREdNUERISU5QS0sYCiABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 9) = "EwoLSklPRERBSE5NRUwYCyABKAgSGgoSY2xpZW50X3Jlc192ZXJzaW9uGAwg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 10) = "ASgNEhoKEnR1cm5fc25hcHNob3RfaGFzaBgNIAEoDBIQCghzdGFnZV9pZBgO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 11) = "IAEoDRIRCgliYXR0bGVfaWQYDyABKA0aMgoQQ0dLRklLS05HSk5FbnRyeRIL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 12) = "CgNrZXkYASABKAkSDQoFdmFsdWUYAiABKA06AjgBQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 13) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray14<string>, string>(in buffer, 14))), new FileDescriptor[3]
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
