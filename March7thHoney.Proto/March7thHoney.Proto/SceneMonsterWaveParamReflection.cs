using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneMonsterWaveParamReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneMonsterWaveParamReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChtTY2VuZU1vbnN0ZXJXYXZlUGFyYW0ucHJvdG8ifwoVU2NlbmVNb25zdGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "V2F2ZVBhcmFtEhgKEGhhcmRfbGV2ZWxfZ3JvdXAYBSABKA0SEwoLQkRDQ0VG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "SE1GSE8YByABKA0SEwoLZWxpdGVfZ3JvdXAYCiABKA0SDQoFbGV2ZWwYDiAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KA0SEwoLT1BKQUZORUZKREMYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneMonsterWaveParam), SceneMonsterWaveParam.Parser, new string[5] { "HardLevelGroup", "BDCCEFHMFHO", "EliteGroup", "Level", "OPJAFNEFJDC" }, null, null, null, null)
		}));
	}
}
