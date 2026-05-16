using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAiPamNextQuestionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAiPamNextQuestionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRBaVBhbU5leHRRdWVzdGlvbkNzUmVxLnByb3RvIhsKGUdldEFpUGFt" + "TmV4dFF1ZXN0aW9uQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAiPamNextQuestionCsReq), GetAiPamNextQuestionCsReq.Parser, null, null, null, null, null)
		}));
	}
}
