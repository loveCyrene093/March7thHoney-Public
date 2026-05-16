using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AetherDivideSpiritExpUpScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AetherDivideSpiritExpUpScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJBZXRoZXJEaXZpZGVTcGlyaXRFeHBVcFNjUnNwLnByb3RvGhFLTkhLQkhB";
		buffer[1] = "REpHRS5wcm90byJnChxBZXRoZXJEaXZpZGVTcGlyaXRFeHBVcFNjUnNwEiEK";
		buffer[2] = "C0hLT0hJSENCR0FBGAEgASgLMgwuS05IS0JIQURKR0USEwoLRklLTExPQ0pC";
		buffer[3] = "R04YAiABKA0SDwoHcmV0Y29kZRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { KNHKBHADJGEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideSpiritExpUpScRsp), AetherDivideSpiritExpUpScRsp.Parser, new string[3] { "HKOHIHCBGAA", "FIKLLOCJBGN", "Retcode" }, null, null, null, null)
		}));
	}
}
