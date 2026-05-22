using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueCommonDialogueDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueCommonDialogueDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVHZXRSb2d1ZUNvbW1vbkRpYWxvZ3VlRGF0YUNzUmVxLnByb3RvIiEKH0dl" + "dFJvZ3VlQ29tbW9uRGlhbG9ndWVEYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueCommonDialogueDataCsReq), GetRogueCommonDialogueDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
