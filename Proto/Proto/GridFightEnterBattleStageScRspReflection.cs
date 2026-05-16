using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightEnterBattleStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightEnterBattleStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiRHcmlkRmlnaHRFbnRlckJhdHRsZVN0YWdlU2NSc3AucHJvdG8aFVNjZW5l";
		buffer[1] = "QmF0dGxlSW5mby5wcm90byJYCh5HcmlkRmlnaHRFbnRlckJhdHRsZVN0YWdl";
		buffer[2] = "U2NSc3ASJQoLYmF0dGxlX2luZm8YAiABKAsyEC5TY2VuZUJhdHRsZUluZm8S";
		buffer[3] = "DwoHcmV0Y29kZRgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightEnterBattleStageScRsp), GridFightEnterBattleStageScRsp.Parser, new string[2] { "BattleInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
