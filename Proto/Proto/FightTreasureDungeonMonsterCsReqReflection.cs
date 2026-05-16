using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightTreasureDungeonMonsterCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightTreasureDungeonMonsterCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiZGaWdodFRyZWFzdXJlRHVuZ2Vvbk1vbnN0ZXJDc1JlcS5wcm90bxoRRk5H";
		buffer[1] = "UEFMQ01CS0sucHJvdG8ibwogRmlnaHRUcmVhc3VyZUR1bmdlb25Nb25zdGVy";
		buffer[2] = "Q3NSZXESEwoLdGFyZ2V0X3NpZGUYBSABKA0SEwoLQ0pPUE5GREJKSEQYCSAB";
		buffer[3] = "KA0SIQoLYXZhdGFyX2xpc3QYDSADKAsyDC5GTkdQQUxDTUJLS0IWqgITTWFy";
		buffer[4] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FNGPALCMBKKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FightTreasureDungeonMonsterCsReq), FightTreasureDungeonMonsterCsReq.Parser, new string[3] { "TargetSide", "CJOPNFDBJHD", "AvatarList" }, null, null, null, null)
		}));
	}
}
