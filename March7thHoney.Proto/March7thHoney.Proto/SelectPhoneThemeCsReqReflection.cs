using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectPhoneThemeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectPhoneThemeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZWxlY3RQaG9uZVRoZW1lQ3NSZXEucHJvdG8iKQoVU2VsZWN0UGhvbmVU" + "aGVtZUNzUmVxEhAKCHRoZW1lX2lkGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectPhoneThemeCsReq), SelectPhoneThemeCsReq.Parser, new string[1] { "ThemeId" }, null, null, null, null)
		}));
	}
}
