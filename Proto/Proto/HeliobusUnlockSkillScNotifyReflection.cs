using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusUnlockSkillScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusUnlockSkillScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFIZWxpb2J1c1VubG9ja1NraWxsU2NOb3RpZnkucHJvdG8iRAobSGVsaW9i" + "dXNVbmxvY2tTa2lsbFNjTm90aWZ5EhMKC0pHS0lCUERBRUZFGAQgASgNEhAK" + "CHNraWxsX2lkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusUnlockSkillScNotify), HeliobusUnlockSkillScNotify.Parser, new string[2] { "JGKIBPDAEFE", "SkillId" }, null, null, null, null)
		}));
	}
}
