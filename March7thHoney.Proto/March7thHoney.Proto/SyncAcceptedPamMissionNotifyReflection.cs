using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncAcceptedPamMissionNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncAcceptedPamMissionNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJTeW5jQWNjZXB0ZWRQYW1NaXNzaW9uTm90aWZ5LnByb3RvIkwKHFN5bmNB" + "Y2NlcHRlZFBhbU1pc3Npb25Ob3RpZnkSFwoPbWFpbl9taXNzaW9uX2lkGAQg" + "ASgNEhMKC05KTU9OR0tMSkpDGAYgASgEQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncAcceptedPamMissionNotify), SyncAcceptedPamMissionNotify.Parser, new string[2] { "MainMissionId", "NJMONGKLJJC" }, null, null, null, null)
		}));
	}
}
