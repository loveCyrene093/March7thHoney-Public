using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncMuseumTargetRewardNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncMuseumTargetRewardNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJTeW5jTXVzZXVtVGFyZ2V0UmV3YXJkTm90aWZ5LnByb3RvIlgKHFN5bmNN" + "dXNldW1UYXJnZXRSZXdhcmROb3RpZnkSDwoHaXRlbV9pZBgDIAEoDRISCgpp" + "dGVtX2NvdW50GA0gASgNEhMKC0xQQUdLSEdDQ0ZIGA4gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncMuseumTargetRewardNotify), SyncMuseumTargetRewardNotify.Parser, new string[3] { "ItemId", "ItemCount", "LPAGKHGCCFH" }, null, null, null, null)
		}));
	}
}
