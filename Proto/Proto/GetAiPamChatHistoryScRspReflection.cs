using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAiPamChatHistoryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAiPamChatHistoryScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5HZXRBaVBhbUNoYXRIaXN0b3J5U2NSc3AucHJvdG8aFUNoYXRNZXNzYWdl";
		buffer[1] = "RGF0YS5wcm90byJnChhHZXRBaVBhbUNoYXRIaXN0b3J5U2NSc3ASDwoHcmV0";
		buffer[2] = "Y29kZRgGIAEoDRITCgt0YXJnZXRfc2lkZRgHIAEoDRIlCgtCQVBNRElFRkRP";
		buffer[3] = "ShgLIAMoCzIQLkNoYXRNZXNzYWdlRGF0YUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ChatMessageDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAiPamChatHistoryScRsp), GetAiPamChatHistoryScRsp.Parser, new string[3] { "Retcode", "TargetSide", "BAPMDIEFDOJ" }, null, null, null, null)
		}));
	}
}
