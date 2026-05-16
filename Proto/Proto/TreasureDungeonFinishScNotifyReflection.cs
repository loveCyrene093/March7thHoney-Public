using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TreasureDungeonFinishScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TreasureDungeonFinishScNotifyReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "CiNUcmVhc3VyZUR1bmdlb25GaW5pc2hTY05vdGlmeS5wcm90byL3AgodVHJl";
		buffer[1] = "YXN1cmVEdW5nZW9uRmluaXNoU2NOb3RpZnkSRAoLRFBBSk1MTkhEREcYAiAD";
		buffer[2] = "KAsyLy5UcmVhc3VyZUR1bmdlb25GaW5pc2hTY05vdGlmeS5EUEFKTUxOSERE";
		buffer[3] = "R0VudHJ5EhMKC0RFT0JPSkNDUEZCGAYgASgNEkQKC0dDR0FMS1BDSENQGAcg";
		buffer[4] = "AygLMi8uVHJlYXN1cmVEdW5nZW9uRmluaXNoU2NOb3RpZnkuR0NHQUxLUENI";
		buffer[5] = "Q1BFbnRyeRIOCgZpc193aW4YCCABKAgSEwoLRENLRUVBS0VPTEMYDCABKA0S";
		buffer[6] = "EwoLQkhNSkZMR01JQ0sYDiABKA0SEwoLdGFyZ2V0X3NpZGUYDyABKA0aMgoQ";
		buffer[7] = "RFBBSk1MTkhEREdFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06";
		buffer[8] = "AjgBGjIKEEdDR0FMS1BDSENQRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVl";
		buffer[9] = "GAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TreasureDungeonFinishScNotify), TreasureDungeonFinishScNotify.Parser, new string[7] { "DPAJMLNHDDG", "DEOBOJCCPFB", "GCGALKPCHCP", "IsWin", "DCKEEAKEOLC", "BHMJFLGMICK", "TargetSide" }, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
