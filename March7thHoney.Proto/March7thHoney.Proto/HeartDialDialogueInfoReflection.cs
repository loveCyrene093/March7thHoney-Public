using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeartDialDialogueInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeartDialDialogueInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtIZWFydERpYWxEaWFsb2d1ZUluZm8ucHJvdG8iQQoVSGVhcnREaWFsRGlh" + "bG9ndWVJbmZvEhMKC2RpYWxvZ3VlX2lkGAMgASgNEhMKC0tPTEpJRE5NUE9O" + "GAUgASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeartDialDialogueInfo), HeartDialDialogueInfo.Parser, new string[2] { "DialogueId", "KOLJIDNMPON" }, null, null, null, null)
		}));
	}
}
