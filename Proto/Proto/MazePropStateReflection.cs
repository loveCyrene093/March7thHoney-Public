using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MazePropStateReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MazePropStateReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNNYXplUHJvcFN0YXRlLnByb3RvGhNQcm9wRXh0cmFJbmZvLnByb3RvImcK" + "DU1hemVQcm9wU3RhdGUSEQoJY29uZmlnX2lkGAggASgNEiIKCmV4dHJhX2lu" + "Zm8YCSABKAsyDi5Qcm9wRXh0cmFJbmZvEg0KBXN0YXRlGAsgASgNEhAKCGdy" + "b3VwX2lkGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PropExtraInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MazePropState), MazePropState.Parser, new string[4] { "ConfigId", "ExtraInfo", "State", "GroupId" }, null, null, null, null)
		}));
	}
}
