using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendRecommendListInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendRecommendListInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVHZXRGcmllbmRSZWNvbW1lbmRMaXN0SW5mb0NzUmVxLnByb3RvIjYKH0dl" + "dEZyaWVuZFJlY29tbWVuZExpc3RJbmZvQ3NSZXESEwoLSUNIRU5PSkVDQVAY" + "CyABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendRecommendListInfoCsReq), GetFriendRecommendListInfoCsReq.Parser, new string[1] { "ICHENOJECAP" }, null, null, null, null)
		}));
	}
}
