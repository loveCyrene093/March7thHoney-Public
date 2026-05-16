using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendApplyListInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendApplyListInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRGcmllbmRBcHBseUxpc3RJbmZvQ3NSZXEucHJvdG8iHQobR2V0RnJp" + "ZW5kQXBwbHlMaXN0SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendApplyListInfoCsReq), GetFriendApplyListInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
