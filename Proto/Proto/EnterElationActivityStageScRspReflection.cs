using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterElationActivityStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterElationActivityStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiRFbnRlckVsYXRpb25BY3Rpdml0eVN0YWdlU2NSc3AucHJvdG8aFVNjZW5l";
		buffer[1] = "QmF0dGxlSW5mby5wcm90byJqCh5FbnRlckVsYXRpb25BY3Rpdml0eVN0YWdl";
		buffer[2] = "U2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIQCghsZXZlbF9pZBgHIAEoDRIlCgti";
		buffer[3] = "YXR0bGVfaW5mbxgLIAEoCzIQLlNjZW5lQmF0dGxlSW5mb0IWqgITTWFyY2g3";
		buffer[4] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterElationActivityStageScRsp), EnterElationActivityStageScRsp.Parser, new string[3] { "Retcode", "LevelId", "BattleInfo" }, null, null, null, null)
		}));
	}
}
