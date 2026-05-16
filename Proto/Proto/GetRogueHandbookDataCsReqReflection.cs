using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueHandbookDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueHandbookDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRSb2d1ZUhhbmRib29rRGF0YUNzUmVxLnByb3RvIhsKGUdldFJvZ3Vl" + "SGFuZGJvb2tEYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueHandbookDataCsReq), GetRogueHandbookDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
