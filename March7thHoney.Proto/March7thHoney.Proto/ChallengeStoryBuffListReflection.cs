using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeStoryBuffListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeStoryBuffListReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDaGFsbGVuZ2VTdG9yeUJ1ZmZMaXN0LnByb3RvIisKFkNoYWxsZW5nZVN0" + "b3J5QnVmZkxpc3QSEQoJYnVmZl9saXN0GAYgAygNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeStoryBuffList), ChallengeStoryBuffList.Parser, new string[1] { "BuffList" }, null, null, null, null)
		}));
	}
}
