using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueAeonInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueAeonInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRSb2d1ZUFlb25JbmZvQ3NSZXEucHJvdG8iFwoVR2V0Um9ndWVBZW9u" + "SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueAeonInfoCsReq), GetRogueAeonInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
