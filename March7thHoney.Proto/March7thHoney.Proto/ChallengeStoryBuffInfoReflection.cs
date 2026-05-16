using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeStoryBuffInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeStoryBuffInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDaGFsbGVuZ2VTdG9yeUJ1ZmZJbmZvLnByb3RvIjwKFkNoYWxsZW5nZVN0" + "b3J5QnVmZkluZm8SEAoIYnVmZl90d28YByABKA0SEAoIYnVmZl9vbmUYDCAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeStoryBuffInfo), ChallengeStoryBuffInfo.Parser, new string[2] { "BuffTwo", "BuffOne" }, null, null, null, null)
		}));
	}
}
