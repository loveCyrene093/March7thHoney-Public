using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NpcMonsterRogueInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NpcMonsterRogueInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChlOcGNNb25zdGVyUm9ndWVJbmZvLnByb3RvGhFIREtESEtQTEJKQy5wcm90";
		buffer[1] = "byKlAQoTTnBjTW9uc3RlclJvZ3VlSW5mbxINCgVsZXZlbBgBIAEoDRITCgtl";
		buffer[2] = "bGl0ZV9ncm91cBgFIAEoDRIhCgtNQ0JQTEdBRUdEShgIIAEoDjIMLkhES0RI";
		buffer[3] = "S1BMQkpDEhMKC09QSkFGTkVGSkRDGAogASgNEhgKEHJvZ3VlX21vbnN0ZXJf";
		buffer[4] = "aWQYDCABKA0SGAoQaGFyZF9sZXZlbF9ncm91cBgPIAEoDUIWqgITTWFyY2g3";
		buffer[5] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HDKDHKPLBJCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NpcMonsterRogueInfo), NpcMonsterRogueInfo.Parser, new string[6] { "Level", "EliteGroup", "MCBPLGAEGDJ", "OPJAFNEFJDC", "RogueMonsterId", "HardLevelGroup" }, null, null, null, null)
		}));
	}
}
