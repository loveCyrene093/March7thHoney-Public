using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterTelevisionActivityStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterTelevisionActivityStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidFbnRlclRlbGV2aXNpb25BY3Rpdml0eVN0YWdlU2NSc3AucHJvdG8aFVNj";
		buffer[1] = "ZW5lQmF0dGxlSW5mby5wcm90byJwCiFFbnRlclRlbGV2aXNpb25BY3Rpdml0";
		buffer[2] = "eVN0YWdlU2NSc3ASEwoLREVCTU9HQ0dNTEkYAiABKA0SDwoHcmV0Y29kZRgK";
		buffer[3] = "IAEoDRIlCgtiYXR0bGVfaW5mbxgLIAEoCzIQLlNjZW5lQmF0dGxlSW5mb0IW";
		buffer[4] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterTelevisionActivityStageScRsp), EnterTelevisionActivityStageScRsp.Parser, new string[3] { "DEBMOGCGMLI", "Retcode", "BattleInfo" }, null, null, null, null)
		}));
	}
}
