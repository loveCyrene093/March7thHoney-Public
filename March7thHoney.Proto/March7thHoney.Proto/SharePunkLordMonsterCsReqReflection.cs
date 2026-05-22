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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch9TaGFyZVB1bmtMb3JkTW9uc3RlckNzUmVxLnByb3RvGhdQdW5rTG9yZFNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "YXJlVHlwZS5wcm90byJkChlTaGFyZVB1bmtMb3JkTW9uc3RlckNzUmVxEhIK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Cm1vbnN0ZXJfaWQYAyABKA0SJgoKc2hhcmVfdHlwZRgMIAEoDjISLlB1bmtM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "b3JkU2hhcmVUeXBlEgsKA3VpZBgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { PunkLordShareTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SharePunkLordMonsterCsReq), SharePunkLordMonsterCsReq.Parser, new string[3] { "MonsterId", "ShareType", "Uid" }, null, null, null, null)
		}));
	}
}
