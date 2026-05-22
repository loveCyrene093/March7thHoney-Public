using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockTutorialCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockTutorialCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlVbmxvY2tUdXRvcmlhbENzUmVxLnByb3RvIioKE1VubG9ja1R1dG9yaWFs" + "Q3NSZXESEwoLdHV0b3JpYWxfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockTutorialCsReq), UnlockTutorialCsReq.Parser, new string[1] { "TutorialId" }, null, null, null, null)
		}));
	}
}
