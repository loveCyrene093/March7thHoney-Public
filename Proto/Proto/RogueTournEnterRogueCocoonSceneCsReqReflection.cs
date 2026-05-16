using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournEnterRogueCocoonSceneCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournEnterRogueCocoonSceneCsReqReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CipSb2d1ZVRvdXJuRW50ZXJSb2d1ZUNvY29vblNjZW5lQ3NSZXEucHJvdG8a";
		buffer[1] = "EUVFQlBISkNOQkZPLnByb3RvIrEBCiRSb2d1ZVRvdXJuRW50ZXJSb2d1ZUNv";
		buffer[2] = "Y29vblNjZW5lQ3NSZXESEwoLTkJESEFEUE5HTkgYASABKAgSDQoFQ291bnQY";
		buffer[3] = "AiABKA0SEwoLSk9NSEVJSExMRE0YAyABKA0SIQoLYXZhdGFyX2xpc3QYBiAD";
		buffer[4] = "KAsyDC5FRUJQSEpDTkJGTxIYChBkaWZmaWN1bHR5X2xldmVsGAkgASgNEhMK";
		buffer[5] = "C0xKUExJSEVQR0hBGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[6] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EEBPHJCNBFOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterRogueCocoonSceneCsReq), RogueTournEnterRogueCocoonSceneCsReq.Parser, new string[6] { "NBDHADPNGNH", "Count", "JOMHEIHLLDM", "AvatarList", "DifficultyLevel", "LJPLIHEPGHA" }, null, null, null, null)
		}));
	}
}
