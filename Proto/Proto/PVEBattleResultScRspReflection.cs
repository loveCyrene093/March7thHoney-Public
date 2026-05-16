using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PVEBattleResultScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PVEBattleResultScRspReflection()
	{
		InlineArray14<string> buffer = default(InlineArray14<string>);
		buffer[0] = "ChpQVkVCYXR0bGVSZXN1bHRTY1JzcC5wcm90bxoSQmF0dGxlQXZhdGFyLnBy";
		buffer[1] = "b3RvGhVCYXR0bGVFbmRTdGF0dXMucHJvdG8aDkl0ZW1MaXN0LnByb3RvGhFO";
		buffer[2] = "Tk9JSkpOQ0hKQi5wcm90byLfAwoUUFZFQmF0dGxlUmVzdWx0U2NSc3ASEwoL";
		buffer[3] = "R0dEQlBEREFQREcYASABKA0SEgoKUmVzVmVyc2lvbhgCIAEoCRIQCghzdGFn";
		buffer[4] = "ZV9pZBgDIAEoDRIkCgplbmRfc3RhdHVzGAQgASgOMhAuQmF0dGxlRW5kU3Rh";
		buffer[5] = "dHVzEiUKEm11bHRpcGxlX2Ryb3BfZGF0YRgFIAEoCzIJLkl0ZW1MaXN0EhwK";
		buffer[6] = "CWRyb3BfZGF0YRgGIAEoCzIJLkl0ZW1MaXN0EiEKDml0ZW1fbGlzdF91bmsx";
		buffer[7] = "GAcgASgLMgkuSXRlbUxpc3QSFwoPY2hlY2tfaWRlbnRpY2FsGAggASgIEikK";
		buffer[8] = "EmJhdHRsZV9hdmF0YXJfbGlzdBgJIAMoCzINLkJhdHRsZUF2YXRhchITCgtD";
		buffer[9] = "SkFKQk1BSk5KUBgKIAEoDRITCgtOREVKSkRISkJJTRgLIAEoDRIQCghldmVu";
		buffer[10] = "dF9pZBgMIAEoDRIRCgliYXR0bGVfaWQYDSABKA0SDwoHcmV0Y29kZRgOIAEo";
		buffer[11] = "DRISCgpCaW5WZXJzaW9uGA8gASgJEiIKDml0ZW1fbGlzdF91bmsyGMwDIAEo";
		buffer[12] = "CzIJLkl0ZW1MaXN0EiIKC0hJQ05GSkRHR0dMGK4MIAEoCzIMLk5OT0lKSk5D";
		buffer[13] = "SEpCQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			BattleAvatarReflection.Descriptor,
			BattleEndStatusReflection.Descriptor,
			ItemListReflection.Descriptor,
			NNOIJJNCHJBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PVEBattleResultScRsp), PVEBattleResultScRsp.Parser, new string[17]
			{
				"GGDBPDDAPDG", "ResVersion", "StageId", "EndStatus", "MultipleDropData", "DropData", "ItemListUnk1", "CheckIdentical", "BattleAvatarList", "CJAJBMAJNJP",
				"NDEJJDHJBIM", "EventId", "BattleId", "Retcode", "BinVersion", "ItemListUnk2", "HICNFJDGGGL"
			}, null, null, null, null)
		}));
	}
}
