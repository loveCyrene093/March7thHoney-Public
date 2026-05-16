using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusEnterBattleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusEnterBattleScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5IZWxpb2J1c0VudGVyQmF0dGxlU2NSc3AucHJvdG8aFVNjZW5lQmF0dGxl";
		buffer[1] = "SW5mby5wcm90byJkChhIZWxpb2J1c0VudGVyQmF0dGxlU2NSc3ASDwoHcmV0";
		buffer[2] = "Y29kZRgFIAEoDRIlCgtiYXR0bGVfaW5mbxgHIAEoCzIQLlNjZW5lQmF0dGxl";
		buffer[3] = "SW5mbxIQCghldmVudF9pZBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusEnterBattleScRsp), HeliobusEnterBattleScRsp.Parser, new string[3] { "Retcode", "BattleInfo", "EventId" }, null, null, null, null)
		}));
	}
}
