using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterLocalLegendLevelScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterLocalLegendLevelScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBFbnRlckxvY2FsTGVnZW5kTGV2ZWxTY1JzcC5wcm90bxoVU2NlbmVCYXR0";
		buffer[1] = "bGVJbmZvLnByb3RvInsKGkVudGVyTG9jYWxMZWdlbmRMZXZlbFNjUnNwEg8K";
		buffer[2] = "B3JldGNvZGUYBCABKA0SJQoLYmF0dGxlX2luZm8YByABKAsyEC5TY2VuZUJh";
		buffer[3] = "dHRsZUluZm8SEAoIZ3JvdXBfaWQYCSABKA0SEwoLSU5PTUZGQUlFT0EYDyAB";
		buffer[4] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterLocalLegendLevelScRsp), EnterLocalLegendLevelScRsp.Parser, new string[4] { "Retcode", "BattleInfo", "GroupId", "INOMFFAIEOA" }, null, null, null, null)
		}));
	}
}
