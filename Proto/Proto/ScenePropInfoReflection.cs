using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ScenePropInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ScenePropInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChNTY2VuZVByb3BJbmZvLnByb3RvGhNQcm9wRXh0cmFJbmZvLnByb3RvIqEB";
		buffer[1] = "Cg1TY2VuZVByb3BJbmZvEhQKDGxpZmVfdGltZV9tcxgBIAEoDRISCgpwcm9w";
		buffer[2] = "X3N0YXRlGAIgASgNEhkKEXRyaWdnZXJfbmFtZV9saXN0GAYgAygJEiIKCmV4";
		buffer[3] = "dHJhX2luZm8YCSABKAsyDi5Qcm9wRXh0cmFJbmZvEhYKDmNyZWF0ZV90aW1l";
		buffer[4] = "X21zGAwgASgEEg8KB3Byb3BfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[5] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PropExtraInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ScenePropInfo), ScenePropInfo.Parser, new string[6] { "LifeTimeMs", "PropState", "TriggerNameList", "ExtraInfo", "CreateTimeMs", "PropId" }, null, null, null, null)
		}));
	}
}
