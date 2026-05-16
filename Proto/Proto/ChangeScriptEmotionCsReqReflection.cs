using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChangeScriptEmotionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChangeScriptEmotionCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5DaGFuZ2VTY3JpcHRFbW90aW9uQ3NSZXEucHJvdG8aGkhlYXJ0RGlhbEVt";
		buffer[1] = "b3Rpb25UeXBlLnByb3RvInYKGENoYW5nZVNjcmlwdEVtb3Rpb25Dc1JlcRIT";
		buffer[2] = "CgtBSUxPTUJJTUlDQhgCIAEoDRIRCglzY3JpcHRfaWQYDSABKA0SMgoTdGFy";
		buffer[3] = "Z2V0X2Vtb3Rpb25fdHlwZRgPIAEoDjIVLkhlYXJ0RGlhbEVtb3Rpb25UeXBl";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HeartDialEmotionTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChangeScriptEmotionCsReq), ChangeScriptEmotionCsReq.Parser, new string[3] { "AILOMBIMICB", "ScriptId", "TargetEmotionType" }, null, null, null, null)
		}));
	}
}
