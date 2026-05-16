using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockTutorialGuideScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockTutorialGuideScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5VbmxvY2tUdXRvcmlhbEd1aWRlU2NSc3AucHJvdG8aE1R1dG9yaWFsR3Vp" + "ZGUucHJvdG8iUwoYVW5sb2NrVHV0b3JpYWxHdWlkZVNjUnNwEg8KB3JldGNv" + "ZGUYCiABKA0SJgoOdHV0b3JpYWxfZ3VpZGUYDiABKAsyDi5UdXRvcmlhbEd1" + "aWRlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { TutorialGuideReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockTutorialGuideScRsp), UnlockTutorialGuideScRsp.Parser, new string[2] { "Retcode", "TutorialGuide" }, null, null, null, null)
		}));
	}
}
