using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SharePunkLordMonsterCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SharePunkLordMonsterCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch9TaGFyZVB1bmtMb3JkTW9uc3RlckNzUmVxLnByb3RvGhdQdW5rTG9yZFNo";
		buffer[1] = "YXJlVHlwZS5wcm90byJkChlTaGFyZVB1bmtMb3JkTW9uc3RlckNzUmVxEhIK";
		buffer[2] = "Cm1vbnN0ZXJfaWQYAyABKA0SJgoKc2hhcmVfdHlwZRgMIAEoDjISLlB1bmtM";
		buffer[3] = "b3JkU2hhcmVUeXBlEgsKA3VpZBgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PunkLordShareTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SharePunkLordMonsterCsReq), SharePunkLordMonsterCsReq.Parser, new string[3] { "MonsterId", "ShareType", "Uid" }, null, null, null, null)
		}));
	}
}
