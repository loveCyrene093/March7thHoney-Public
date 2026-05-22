using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleMonsterParamReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleMonsterParamReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChhCYXR0bGVNb25zdGVyUGFyYW0ucHJvdG8ifAoSQmF0dGxlTW9uc3RlclBh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cmFtEhgKEGhhcmRfbGV2ZWxfZ3JvdXAYASABKA0SDQoFbGV2ZWwYAiABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EwoLZWxpdGVfZ3JvdXAYAyABKA0SEwoLT1BKQUZORUZKREMYBCABKA0SEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "QkRDQ0VGSE1GSE8YBSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleMonsterParam), BattleMonsterParam.Parser, new string[5] { "HardLevelGroup", "Level", "EliteGroup", "OPJAFNEFJDC", "BDCCEFHMFHO" }, null, null, null, null)
		}));
	}
}
