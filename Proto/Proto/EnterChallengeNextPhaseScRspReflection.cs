using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterChallengeNextPhaseScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterChallengeNextPhaseScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJFbnRlckNoYWxsZW5nZU5leHRQaGFzZVNjUnNwLnByb3RvGg9TY2VuZUlu" + "Zm8ucHJvdG8iSgocRW50ZXJDaGFsbGVuZ2VOZXh0UGhhc2VTY1JzcBIPCgdy" + "ZXRjb2RlGAQgASgNEhkKBXNjZW5lGAkgASgLMgouU2NlbmVJbmZvQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { SceneInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterChallengeNextPhaseScRsp), EnterChallengeNextPhaseScRsp.Parser, new string[2] { "Retcode", "Scene" }, null, null, null, null)
		}));
	}
}
