using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAetherDivideChallengeInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAetherDivideChallengeInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidHZXRBZXRoZXJEaXZpZGVDaGFsbGVuZ2VJbmZvQ3NSZXEucHJvdG8iIwoh" + "R2V0QWV0aGVyRGl2aWRlQ2hhbGxlbmdlSW5mb0NzUmVxQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAetherDivideChallengeInfoCsReq), GetAetherDivideChallengeInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
