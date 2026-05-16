using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncApplyFriendScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncApplyFriendScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TeW5jQXBwbHlGcmllbmRTY05vdGlmeS5wcm90bxoVRnJpZW5kQXBwbHlJ" + "bmZvLnByb3RvIkYKF1N5bmNBcHBseUZyaWVuZFNjTm90aWZ5EisKEWZyaWVu" + "ZF9hcHBseV9pbmZvGAQgASgLMhAuRnJpZW5kQXBwbHlJbmZvQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { FriendApplyInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncApplyFriendScNotify), SyncApplyFriendScNotify.Parser, new string[1] { "FriendApplyInfo" }, null, null, null, null)
		}));
	}
}
