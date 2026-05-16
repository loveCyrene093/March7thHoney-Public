using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncRogueCommonDialogueOptionFinishScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncRogueCommonDialogueOptionFinishScNotifyReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CjFTeW5jUm9ndWVDb21tb25EaWFsb2d1ZU9wdGlvbkZpbmlzaFNjTm90aWZ5";
		buffer[1] = "LnByb3RvGhFHQkhIT01ITkxLRC5wcm90bxoRSklCTUpDQk5ES0sucHJvdG8i";
		buffer[2] = "nQEKK1N5bmNSb2d1ZUNvbW1vbkRpYWxvZ3VlT3B0aW9uRmluaXNoU2NOb3Rp";
		buffer[3] = "ZnkSEwoLQU1BREZKTkhNRkYYBiABKA0SIQoLS0FNTUJNUEZBRUMYCiABKAsy";
		buffer[4] = "DC5HQkhIT01ITkxLRBIhCgtMRlBMQ0RNTk5BUBgLIAEoCzIMLkpJQk1KQ0JO";
		buffer[5] = "REtLEhMKC0hPSEFOUEpOQU5BGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[6] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GBHHOMHNLKDReflection.Descriptor,
			JIBMJCBNDKKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueCommonDialogueOptionFinishScNotify), SyncRogueCommonDialogueOptionFinishScNotify.Parser, new string[4] { "AMADFJNHMFF", "KAMMBMPFAEC", "LFPLCDMNNAP", "HOHANPJNANA" }, null, null, null, null)
		}));
	}
}
