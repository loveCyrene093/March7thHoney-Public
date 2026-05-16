using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TextJoinBatchSaveCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TextJoinBatchSaveCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUZXh0Sm9pbkJhdGNoU2F2ZUNzUmVxLnByb3RvGhFDRURHTklJRUlNQy5w" + "cm90byI+ChZUZXh0Sm9pbkJhdGNoU2F2ZUNzUmVxEiQKDnRleHRfam9pbl9s" + "aXN0GA4gAygLMgwuQ0VER05JSUVJTUNCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[1] { CEDGNIIEIMCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TextJoinBatchSaveCsReq), TextJoinBatchSaveCsReq.Parser, new string[1] { "TextJoinList" }, null, null, null, null)
		}));
	}
}
