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
		buffer[0] = "ChtTY2VuZU1vbnN0ZXJXYXZlUGFyYW0ucHJvdG8ifwoVU2NlbmVNb25zdGVy";
		buffer[1] = "V2F2ZVBhcmFtEhgKEGhhcmRfbGV2ZWxfZ3JvdXAYBSABKA0SEwoLQkRDQ0VG";
		buffer[2] = "SE1GSE8YByABKA0SEwoLZWxpdGVfZ3JvdXAYCiABKA0SDQoFbGV2ZWwYDiAB";
		buffer[3] = "KA0SEwoLT1BKQUZORUZKREMYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[4] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneMonsterWaveParam), SceneMonsterWaveParam.Parser, new string[5] { "HardLevelGroup", "BDCCEFHMFHO", "EliteGroup", "Level", "OPJAFNEFJDC" }, null, null, null, null)
		}));
	}
}
