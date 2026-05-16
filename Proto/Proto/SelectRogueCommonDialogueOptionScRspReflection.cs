using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectRogueCommonDialogueOptionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectRogueCommonDialogueOptionScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CipTZWxlY3RSb2d1ZUNvbW1vbkRpYWxvZ3VlT3B0aW9uU2NSc3AucHJvdG8a";
		buffer[1] = "EUpJQk1KQ0JOREtLLnByb3RvIq4BCiRTZWxlY3RSb2d1ZUNvbW1vbkRpYWxv";
		buffer[2] = "Z3VlT3B0aW9uU2NSc3ASEwoLTUZITEJIRklBR08YAiABKAgSEwoLQU1BREZK";
		buffer[3] = "TkhNRkYYBSABKA0SEwoLSE9IQU5QSk5BTkEYByABKA0SEwoLRExFR0NOSklO";
		buffer[4] = "SUUYCiADKA0SIQoLTEZQTENETU5OQVAYDCABKAsyDC5KSUJNSkNCTkRLSxIP";
		buffer[5] = "CgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[6] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JIBMJCBNDKKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectRogueCommonDialogueOptionScRsp), SelectRogueCommonDialogueOptionScRsp.Parser, new string[6] { "MFHLBHFIAGO", "AMADFJNHMFF", "HOHANPJNANA", "DLEGCNJINIE", "LFPLCDMNNAP", "Retcode" }, null, null, null, null)
		}));
	}
}
