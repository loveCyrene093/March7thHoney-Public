using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournExpNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournExpNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlSb2d1ZVRvdXJuRXhwTm90aWZ5LnByb3RvIiIKE1JvZ3VlVG91cm5FeHBO" + "b3RpZnkSCwoDZXhwGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournExpNotify), RogueTournExpNotify.Parser, new string[1] { "Exp" }, null, null, null, null)
		}));
	}
}
