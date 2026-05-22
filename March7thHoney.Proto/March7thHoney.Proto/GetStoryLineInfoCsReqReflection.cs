using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetStoryLineInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetStoryLineInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRTdG9yeUxpbmVJbmZvQ3NSZXEucHJvdG8iFwoVR2V0U3RvcnlMaW5l" + "SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetStoryLineInfoCsReq), GetStoryLineInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
