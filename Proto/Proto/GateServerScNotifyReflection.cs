using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GateServerScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GateServerScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhHYXRlU2VydmVyU2NOb3RpZnkucHJvdG8iKQoSR2F0ZVNlcnZlclNjTm90" + "aWZ5EhMKC0tHSEhCTEdQSkpJGAsgASgJQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GateServerScNotify), GateServerScNotify.Parser, new string[1] { "KGHHBLGPJJI" }, null, null, null, null)
		}));
	}
}
