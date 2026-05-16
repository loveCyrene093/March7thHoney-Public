using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartBattleCollegeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartBattleCollegeScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1TdGFydEJhdHRsZUNvbGxlZ2VTY1JzcC5wcm90bxoVU2NlbmVCYXR0bGVJ";
		buffer[1] = "bmZvLnByb3RvIl0KF1N0YXJ0QmF0dGxlQ29sbGVnZVNjUnNwEg8KB3JldGNv";
		buffer[2] = "ZGUYByABKA0SCgoCaWQYCCABKA0SJQoLYmF0dGxlX2luZm8YDSABKAsyEC5T";
		buffer[3] = "Y2VuZUJhdHRsZUluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartBattleCollegeScRsp), StartBattleCollegeScRsp.Parser, new string[3] { "Retcode", "Id", "BattleInfo" }, null, null, null, null)
		}));
	}
}
