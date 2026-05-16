using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockPamSkinScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockPamSkinScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtVbmxvY2tQYW1Ta2luU2NOb3RpZnkucHJvdG8iKQoVVW5sb2NrUGFtU2tp" + "blNjTm90aWZ5EhAKCHBhbV9za2luGAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockPamSkinScNotify), UnlockPamSkinScNotify.Parser, new string[1] { "PamSkin" }, null, null, null, null)
		}));
	}
}
