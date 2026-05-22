using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTutorialGuideCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTutorialGuideCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRUdXRvcmlhbEd1aWRlQ3NSZXEucHJvdG8iFwoVR2V0VHV0b3JpYWxH" + "dWlkZUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTutorialGuideCsReq), GetTutorialGuideCsReq.Parser, null, null, null, null, null)
		}));
	}
}
