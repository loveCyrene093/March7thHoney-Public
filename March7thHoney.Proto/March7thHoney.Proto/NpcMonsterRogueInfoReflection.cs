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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChlOcGNNb25zdGVyUm9ndWVJbmZvLnByb3RvGhFIREtESEtQTEJKQy5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "byKlAQoTTnBjTW9uc3RlclJvZ3VlSW5mbxINCgVsZXZlbBgBIAEoDRITCgtl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "bGl0ZV9ncm91cBgFIAEoDRIhCgtNQ0JQTEdBRUdEShgIIAEoDjIMLkhES0RI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "S1BMQkpDEhMKC09QSkFGTkVGSkRDGAogASgNEhgKEHJvZ3VlX21vbnN0ZXJf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "aWQYDCABKA0SGAoQaGFyZF9sZXZlbF9ncm91cBgPIAEoDUIWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { HDKDHKPLBJCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NpcMonsterRogueInfo), NpcMonsterRogueInfo.Parser, new string[6] { "Level", "EliteGroup", "MCBPLGAEGDJ", "OPJAFNEFJDC", "RogueMonsterId", "HardLevelGroup" }, null, null, null, null)
		}));
	}
}
